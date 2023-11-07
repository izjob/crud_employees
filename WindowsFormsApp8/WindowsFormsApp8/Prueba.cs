using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    public class Prueba
    {
        Linq1DataContext db = new Linq1DataContext();

        public List<employees> listar()
        {
            List<employees> list=db.employees.ToList();
            return list;
        }

        public void registrar(employees emp) 
        {
            db.employees.InsertOnSubmit(emp);
        }
        /*
        public void actualizar(employees emp)
        {
            employees actualizado = db.employees.Single(r => r.employee_id == emp.employee_id);
            actualizado.first_name = emp.first_name;

            //aqui faltaria añadir los campos modificables

            db.SubmitChanges();
        }
        */
        public void eliminar (int key)
        {
            employees eliminado = db.employees.Single(r => r.employee_id == key);
            db.employees.DeleteOnSubmit(eliminado);
            db.SubmitChanges();
        }


        // 7:17 mira foto movil 
    }
}
