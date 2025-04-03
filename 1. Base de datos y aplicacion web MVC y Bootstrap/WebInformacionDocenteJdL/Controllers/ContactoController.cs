using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Configuration;
using WebInformacionDocenteJdL.Models;
using System.Data.SqlClient;
using System.Data;

namespace WebInformacionDocenteJdL.Controllers
{
    public class ContactoController : Controller
    {
        private static string lStrConexion = ConfigurationManager.ConnectionStrings["lStrCadena"].ToString();

        private static List<Contacto> lObjLista = new List<Contacto>();

        // GET: Contacto
        public ActionResult Inicio()
        {

            lObjLista = new List<Contacto>();

            using (SqlConnection lObjConexion = new SqlConnection(lStrConexion))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM DOCENTE", lObjConexion);
                cmd.CommandType = CommandType.Text;
                lObjConexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Contacto nuevoContacto = new Contacto();

                        nuevoContacto.lIntIdContacto = Convert.ToInt32(dr["IdDocente"]);
                        nuevoContacto.lStrNombres = dr["Nombres"].ToString();
                        nuevoContacto.lStrApellidos = dr["Apellidos"].ToString();
                        nuevoContacto.lStrTelefono = dr["Telefono"].ToString();
                        nuevoContacto.lStrCorreo = dr["Correo"].ToString();
                        nuevoContacto.lDblSalario = Convert.ToDecimal(dr["Salario"]);
                        nuevoContacto.lStrFechaNacimiento = DateTime.Parse(dr["FechaNacimiento"].ToString());

                        lObjLista.Add(nuevoContacto);
                    }
                }
            }
            return View(lObjLista);
        }

        public ActionResult Registrar()
        {
            return View();
        }

        public ActionResult Editar(int? idcontacto)
        {
            if (idcontacto == null)
                return RedirectToAction("Inicio", "Contacto");

            Contacto lobjcontacto = lObjLista.Where(c => c.lIntIdContacto == idcontacto).FirstOrDefault();

            return View(lobjcontacto);
        }

        public ActionResult Eliminar(int? idcontacto)
        {
            if (idcontacto == null)
                return RedirectToAction("Inicio", "Contacto");

            Contacto lobjcontacto = lObjLista.Where(c => c.lIntIdContacto == idcontacto).FirstOrDefault();

            return View(lobjcontacto);
        }

        [HttpPost]
        public ActionResult Registrar(Contacto lObjContacto)
        {
            using (SqlConnection lObjConexion = new SqlConnection(lStrConexion))
            {
                SqlCommand cmd = new SqlCommand("sp_Registrar", lObjConexion);
                cmd.Parameters.AddWithValue("Nombres", lObjContacto.lStrNombres);
                cmd.Parameters.AddWithValue("Apellidos", lObjContacto.lStrApellidos);
                cmd.Parameters.AddWithValue("Telefono", lObjContacto.lStrTelefono);
                cmd.Parameters.AddWithValue("Correo", lObjContacto.lStrCorreo);
                cmd.Parameters.AddWithValue("Salario", lObjContacto.lDblSalario);
                cmd.Parameters.AddWithValue("FechaNacimiento", lObjContacto.lStrFechaNacimiento);
                cmd.CommandType = CommandType.StoredProcedure;
                lObjConexion.Open();
                cmd.ExecuteNonQuery();
            }
            return RedirectToAction("Inicio", "Contacto");
        }

        [HttpPost]
        public ActionResult Editar(Contacto lObjContacto)
        {
            using (SqlConnection lObjConexion = new SqlConnection(lStrConexion))
            {
                SqlCommand cmd = new SqlCommand("sp_Editar", lObjConexion);
                cmd.Parameters.AddWithValue("IdDocente", lObjContacto.lIntIdContacto);
                cmd.Parameters.AddWithValue("Nombres", lObjContacto.lStrNombres);
                cmd.Parameters.AddWithValue("Apellidos", lObjContacto.lStrApellidos);
                cmd.Parameters.AddWithValue("Telefono", lObjContacto.lStrTelefono);
                cmd.Parameters.AddWithValue("Correo", lObjContacto.lStrCorreo);
                cmd.Parameters.AddWithValue("Salario", lObjContacto.lDblSalario);
                cmd.Parameters.AddWithValue("FechaNacimiento", lObjContacto.lStrFechaNacimiento);
                cmd.CommandType = CommandType.StoredProcedure;
                lObjConexion.Open();
                cmd.ExecuteNonQuery();
            }
            return RedirectToAction("Inicio", "Contacto");
        }

        [HttpPost]
        public ActionResult Eliminar(string lIntIdContacto)
        {
            using (SqlConnection lObjConexion = new SqlConnection(lStrConexion))
            {
                SqlCommand cmd = new SqlCommand("sp_Eliminar", lObjConexion);
                cmd.Parameters.AddWithValue("IdDocente", lIntIdContacto);
                cmd.CommandType = CommandType.StoredProcedure;
                lObjConexion.Open();
                cmd.ExecuteNonQuery();
            }
            return RedirectToAction("Inicio", "Contacto");
        }

        public ActionResult About ()
        {
            ViewBag.Message = "Acerca de la aplicacion.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "DETALLES";
            return View();
        }
    }
}