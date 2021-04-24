using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_SIVENTU
{
    class ventura
    {
        Conexion conn = new Conexion();

        public bool Login(string Nombre, string password)
        {
            string query = string.Format("Select * from usuarios where name='{0}' and password='{1}'", Nombre, password);
           DataRow[] dt = conn.readQuery(query, "Table", true);

            if (dt.Length == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        // LOGIN
        public bool Register(string Nombre, string password1,string Sexo, string Correo,string Telefono)
        {
            bool set = conn.setData(string.Format("insert into usuarios (name, password, phone, sex, email) values ('{0}', '{1}', '{2}', '{3}', '{4}')", Nombre, password1, Telefono, Sexo, Correo));
            return set;
        }

        internal bool Register(string nombre, string password1, string correo, string Telé)
        {
            throw new NotImplementedException();
        }
        
        //CLIENTES
        public bool Registrar(string codigo, string nombre, string sexo, string telefono, string email, string direccion, string fecha)
        {    
            bool set = conn.setData(string.Format("insert into clientes (code, name, sex, phone, email, direccion, date) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", codigo, nombre, sexo, telefono, email, direccion, fecha));
            return set;
        }

        internal bool Registrar(string codigo, string nombre, string telefono, string email, string direccion, string fecha)
        {
           throw new NotImplementedException();
        }


       //PROVEEDORES

        public bool Registrador(string codigo, string nombre, string direccion, string telefono, string correo, string rubro, string product, string fecha)
        {
            bool set = conn.setData(string.Format("insert into proveedores (code, name, direccion, phone, email, rubro, product, date) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", codigo, nombre, direccion, telefono, correo, rubro, product, fecha));
            return set;
        }

        internal bool Registrador(string codigo, string nombre, string direccion, string pais, string telefono, string correo, string rubro, string product, string fecha)
        {
            throw new NotImplementedException();
        }

        //PRODUCTOS
        public bool Registradorpro(string codigo_prod, string descripcion, string precio, string existencias, string fecha)
        {
            bool set = conn.setData(string.Format("insert into productos (code, description, price, stocks, date) values ('{0}', '{1}', '{2}', '{3}', '{4}')", codigo_prod, descripcion, precio, existencias, fecha));
            return set;
        }
        internal bool Registradorpro( string descripcion, string precio, string existencias, string fecha)
        {
            throw new NotImplementedException();
        }
        //COMPRAS

        public bool Registercom(string codigo, string proveedor, string direccion, string telefono, string numerocom, string prododucosoli, string cantidad, string total, string descrip, string observa, string fecha)
        {
            bool set = conn.setData(string.Format("insert into compras (codigo, proveedor, direccion, telefono, N° de compra, Producto solicitado, Cantidad, Total de Compra, Descripcion, Observaciones, Fecha) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')", codigo, proveedor, direccion, telefono, numerocom, prododucosoli, cantidad, total, descrip, observa, fecha));
            return set;
        }
        
        internal bool Registercom(string codigo, string proveedor, string direccion, string telefono, string numerocom, string prododucosoli, string cantidad, string total, string descrip, string observa)
        {
            throw new NotImplementedException();
        }
    }
 
}
