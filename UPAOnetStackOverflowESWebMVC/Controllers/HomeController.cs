using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UPAOnetStackOverflowESEntidades;

namespace UPAOnetStackOverflowESWebMVC.Controllers
{    
    public class HomeController : Controller
    {
        private UPAOnetStackOverflowESBaseDeDatosEntities db = new UPAOnetStackOverflowESBaseDeDatosEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Enroll()
        {
            //necesitamos mostrar todos los cursos que hay
            List<Curso> lCursos = new List<Curso>();
            lCursos = db.Cursos.ToList();
            ViewBag.listaCursos = lCursos;
            //necesitamos mostrar todos los estudiantes que hay.
            List<Estudiante> lEstudiantes = new List<Estudiante>();
            lEstudiantes = db.Estudiantes.ToList();
            ViewBag.listaEstudiantes = lEstudiantes;
            return View();
        }

        [HttpPost]
        public ActionResult Enroll(string curso, string estudiante)
        {
            EnlaceEstudianteCurso entidad = new EnlaceEstudianteCurso();
            entidad.CursoID = int.Parse(curso);
            entidad.EstudianteID = int.Parse(estudiante);
            db.EnlaceEstudianteCursoes.Add(entidad);
            db.SaveChanges();

            //necesitamos mostrar todos los cursos que hay
            List<Curso> lCursos = new List<Curso>();
            lCursos = db.Cursos.ToList();
            ViewBag.listaCursos = lCursos;
            //necesitamos mostrar todos los estudiantes que hay.
            List<Estudiante> lEstudiantes = new List<Estudiante>();
            lEstudiantes = db.Estudiantes.ToList();
            ViewBag.listaEstudiantes = lEstudiantes;

            return View();
        }
    }
}