namespace _03_Dominio.Entidades
{
    public class Usuario
  {
        Guid id;
        string nombre;
        string email;
        string clave;
        DateTime fechaNacimiento;

        public Usuario(Guid id,string nombre,string email, string clave, DateTime fechaNacimiento)


        {//controlar que el nombre este completo
            this.debeContenerNombre(nombre);
            //controlar que el email sea valido
            //controlar que el usuario sea mayor a 18 años
            this.id = id;
            this.nombre = nombre;  
            this.email = email;
            this.clave = clave;
            this.fechaNacimiento = fechaNacimiento;
        }



    private void debeContenerNombre(string nombre)
    {
            if (nombre == "") 
            { 
                throw new Exception("El nombre no debe ser vacio"); 
            }
    }
  }
}