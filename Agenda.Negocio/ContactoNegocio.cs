using System;
using System.Collections.Generic;
using Agenda.Datos;
using Agenda.Entidades;

namespace Agenda.Negocio
{
    public class ContactoNegocio
    {
        private readonly ContactoDatos datos = new ContactoDatos();

        public int Insertar(Contacto contacto)
        {
            ValidarContacto(contacto);
            return datos.Insertar(contacto);
        }

        public int Modificar(Contacto contacto)
        {
            if (contacto.Id <= 0)
                throw new Exception("El ID del contacto no es válido.");

            ValidarContacto(contacto);

            return datos.Modificar(contacto);
        }

        public int Eliminar(int id)
        {
            if (id <= 0)
                throw new Exception("Debe seleccionar un contacto válido.");

            int resultado = datos.Eliminar(id);

            if (resultado == 0)
                throw new Exception("No se encontró el contacto que desea eliminar.");

            return resultado;
        }

        public List<Contacto> Buscar(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return datos.Listar();

            return datos.Buscar(texto.Trim());
        }

        public List<Contacto> Listar()
        {
            return datos.Listar();
        }

        private void ValidarContacto(Contacto contacto)
        {
            if (contacto == null)
                throw new Exception("El contacto no puede estar vacío.");

            if (string.IsNullOrWhiteSpace(contacto.Nombre))
                throw new Exception("El nombre del contacto es obligatorio.");

            if (contacto.Nombre.Trim().Length > 100)
                throw new Exception("El nombre no puede superar los 100 caracteres.");

            if (string.IsNullOrWhiteSpace(contacto.Telefono))
                throw new Exception("El teléfono del contacto es obligatorio.");

            if (contacto.Telefono.Trim().Length > 20)
                throw new Exception("El teléfono no puede superar los 20 caracteres.");

            if (contacto.Correo != null && contacto.Correo.Length > 100)
                throw new Exception("El correo no puede superar los 100 caracteres.");

            if (contacto.Direccion != null && contacto.Direccion.Length > 200)
                throw new Exception("La dirección no puede superar los 200 caracteres.");

            contacto.Nombre = contacto.Nombre.Trim();
            contacto.Telefono = contacto.Telefono.Trim();
            contacto.Correo = contacto.Correo?.Trim();
            contacto.Direccion = contacto.Direccion?.Trim();
        }
    }
}
