using prueba.Modelos.Request;
using prueba.Modelos.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using prueba.AccesoDatos;
using prueba.Modelos.Entidades;

namespace prueba.Logica
{
    public class LogProyecto
    {
        /// TODO USUARIO ESTA LISTO
        public ResInsertarUsuario insertarUsuario(ReqInsertarUsuario req)
        {
            ResInsertarUsuario res = new ResInsertarUsuario();

            try
            {
                if (req == null)
                {
                    res.resultado = false;
                    res.error = "Bad request";
                }
                else
                {
                    if (String.IsNullOrEmpty(req.usuario.cedula))
                    {
                        res.resultado = false;
                        res.error = "cedula Incorrecto";

                    }
                    else if (String.IsNullOrEmpty(req.usuario.nombre))
                    {
                        res.resultado = false;
                        res.error = "Nombre Incorrecto";

                    }
                    else if (String.IsNullOrEmpty(req.usuario.email))
                    {
                        res.resultado = false;
                        res.error = "Email Incorrecto";
                    }
                    else if (String.IsNullOrEmpty(req.usuario.password))
                    {
                        res.resultado = false;
                        res.error = "Password Incorrecto";
                    }
                    else
                    {
                        int? returnId = 0;
                        int? errorId = 0;
                        string errorDescripcion = "";

                        ConexionLINQDataContext miLinq = new ConexionLINQDataContext();
                        miLinq.SP_INGRESAR_USUARIO(req.usuario.cedula, req.usuario.nombre, req.usuario.email, req.usuario.password, ref returnId, ref errorId, ref errorDescripcion);
                        if (returnId <= 0 || returnId == null)
                        {

                            res.resultado = false;
                            res.error = errorDescripcion;
                        }
                        else
                        {
                            //todo paso bien

                            res.resultado = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                res.resultado = false;
                res.error = "500- Error Interno";
            }

            return res;
        }
        //listo
        public ResActualizarUsuario actualizarUsuario(ReqActualizarUsuario req)
        {
            ResActualizarUsuario res = new ResActualizarUsuario();

            try
            {
                if (req == null)
                {
                    res.resultado = false;
                    res.error = "Bad request";
                }
                else
                {
                    if (String.IsNullOrEmpty(req.usuario.cedula))
                    {
                        res.resultado = false;
                        res.error = "Nombre Incorrecto";

                    }
                    else if (String.IsNullOrEmpty(req.usuario.nombre))
                    {
                        res.resultado = false;
                        res.error = "Nombre Incorrecto";

                    }
                    else if (String.IsNullOrEmpty(req.usuario.email))
                    {
                        res.resultado = false;
                        res.error = "Email Incorrecto";
                    }
                    else if (String.IsNullOrEmpty(req.usuario.password))
                    {
                        res.resultado = false;
                        res.error = "Password Incorrecto";
                    }
                    else
                    {
                        int? returnId = 0;
                        int? errorId = 0;
                        string errorDescripcion = "";

                        ConexionLINQDataContext miLinq = new ConexionLINQDataContext();
                        miLinq.SP_ACTUALIZAR_USUARIO(req.usuario.cedula, req.usuario.nombre, req.usuario.email, req.usuario.password, ref returnId, ref errorId, ref errorDescripcion);
                        if (returnId <= 0 || returnId == null)
                        {

                            res.resultado = false;
                            res.error = errorDescripcion;
                        }
                        else
                        {
                            //todo paso bien

                            res.resultado = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                res.resultado = false;
                res.error = "500- Error Interno";
            }

            return res;
        }
        //listo
        public ResEliminarUsuario eliminarUsuario(ReqEliminarUsuario req)
        {
            ResEliminarUsuario res = new ResEliminarUsuario();

            try
            {
                if (req == null)
                {
                    res.resultado = false;
                    res.error = "Bad request";
                }
                else
                {
                    if (String.IsNullOrEmpty(req.usuario.cedula))
                    {
                        res.resultado = false;
                        res.error = "cedula Incorrecto";

                    }
                    else
                    {
                        int? returnId = 0;
                        int? errorId = 0;
                        string errorDescripcion = "";

                        ConexionLINQDataContext miLinq = new ConexionLINQDataContext();
                        miLinq.SP_ELIMINAR_USUARIO(req.usuario.cedula, ref returnId, ref errorId, ref errorDescripcion);
                        if (returnId <= 0 || returnId == null)
                        {

                            res.resultado = false;
                            res.error = errorDescripcion;
                        }
                        else
                        {
                            //todo paso bien

                            res.resultado = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                res.resultado = false;
                res.error = "500- Error Interno";
            }

            return res;
        }
        //listo



        /// TODO LOGIN ESTA LISTO
        public ResLogin entrarlogin(ReqLogin req)
        {
            ResLogin res = new ResLogin();

            try
            {
                if (req == null)
                {
                    res.resultado = false;
                    res.error = "Bad request";
                    return res;
                }

                if (String.IsNullOrEmpty(req.login.email))
                {
                    res.resultado = false;
                    res.error = "Correo Incorrecto";
                    return res;
                }

                if (String.IsNullOrEmpty(req.login.password))
                {
                    res.resultado = false;
                    res.error = "Password Incorrecto";
                    return res;
                }

                // Declarar variables necesarias
                int? errorId = 0;
                string errorDescripcion = "";
                long? sesion_id = 0;
                int? id_usuario = 0;

                // Crear instancia de la clase de acceso a datos
                ConexionLINQDataContext miLinq = new ConexionLINQDataContext();

                // Llamar al procedimiento almacenado
                miLinq.SP_LOGIN_USUARIO(req.login.email, req.login.password, ref sesion_id, ref id_usuario, ref errorId, ref errorDescripcion);

                if (sesion_id.HasValue && sesion_id.Value > 0 && errorId == 0)
                {
                    // Login exitoso
                    res.resultado = true;
                    res.sesion_id = sesion_id; // Asigna el valor de sesion_id
                    res.id_usuario = id_usuario;
                }
                else
                {
                    // Login fallido
                    res.resultado = false;
                    res.error = string.IsNullOrEmpty(errorDescripcion) ? "Credenciales incorrectas" : errorDescripcion;
                }
            }
            catch (Exception ex)
            {
                res.resultado = false;
                res.error = "500- Error Interno: " + ex.Message;
            }

            return res;
        }
        //listo


        public ResSalirLogin salirlogin(ReqSalirLogin req)
        {
            ResSalirLogin res = new ResSalirLogin();

            try
            {
                if (req == null)
                {
                    res.resultado = false;
                    res.error = "Bad request";
                }
                else
                {
                    if (req.login.sesion_id == 0)
                    {
                        res.resultado = false;
                        res.error = "Sesion Incorrecta";
                    }
                    else
                    {
                        int? returnId = 0;
                        int? errorId = 0;
                        string errorDescripcion = "";

                        ConexionLINQDataContext miLinq = new ConexionLINQDataContext();
                        miLinq.SP_CERRAR_SESION(req.login.sesion_id, ref returnId, ref errorId, ref errorDescripcion);
                        if (errorId == 0)
                        {
                            // Cierre de sesión exitoso
                            res.resultado = true;
                        }
                        else
                        {
                            // Cierre de sesión fallido
                            res.resultado = false;
                            res.error = string.IsNullOrEmpty(errorDescripcion) ? "Error al cerrar sesión" : errorDescripcion;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                res.resultado = false;
                res.error = "500- Error Interno";
            }

            return res;
        }
        //listo


        /// PRODUCTO
        public ResAgregarProducto agregarProducto(ReqAgregarProducto req)
        {
            ResAgregarProducto res = new ResAgregarProducto();

            try
            {
                if (req == null)
                {
                    res.resultado = false;
                    res.error = "Bad request";
                }
                else
                {
                    if (String.IsNullOrEmpty(req.producto.nombre_categoria))
                    {
                        res.resultado = false;
                        res.error = "Categoria Incorrecta";
                    }

                    if (String.IsNullOrEmpty(req.producto.nombre))
                    {
                        res.resultado = false;
                        res.error = "Nombre Incorrecto";

                    }

                    else if (String.IsNullOrEmpty(req.producto.descripcion))
                    {
                        res.resultado = false;
                        res.error = "Descripcion Incorrecta";
                    }

                    if (req.producto.precio_producto == 0)
                    {
                        res.resultado = false;
                        res.error = "Precio Incorrecto";
                    }


                    else
                    {
                        int? returnId = 0;
                        int? errorId = 0;
                        string errorDescripcion = "";

                        ConexionLINQDataContext miLinq = new ConexionLINQDataContext();
                        miLinq.SP_AGREGAR_PRODUCTO(req.producto.nombre_categoria, req.producto.nombre, req.producto.descripcion, req.producto.precio_producto, ref returnId, ref errorId, ref errorDescripcion);
                        if (returnId <= 0 || returnId == null)
                        {

                            res.resultado = false;
                            res.error = errorDescripcion;
                        }
                        else
                        {
                            //todo paso bien

                            res.resultado = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                res.resultado = false;
                res.error = "500- Error Interno";
            }

            return res;
        }
        //listo

        public ResActualizarProducto actualizarProducto(ReqActualizarProducto req)
        {
            ResActualizarProducto res = new ResActualizarProducto();

            try
            {
                if (req == null)
                {
                    res.resultado = false;
                    res.error = "Bad request";
                }
                else
                {
                    if (String.IsNullOrEmpty(req.producto.nombre_actual))
                    {
                        res.resultado = false;
                        res.error = "Nombre Incorrecto";
                    }

                    if (String.IsNullOrEmpty(req.producto.nuevo_nombre))
                    {
                        res.resultado = false;
                        res.error = "Nombre Incorrecto";
                    }

                    else if (String.IsNullOrEmpty(req.producto.descripcion))
                    {
                        res.resultado = false;
                        res.error = "Descripcion Incorrecta";
                    }

                    else if (req.producto.precio_producto <= 0)
                    {
                        res.resultado = false;
                        res.error = "Precio Incorrecto";
                    }

                    else if (String.IsNullOrEmpty(req.producto.nombre_categoria))
                    {
                        res.resultado = false;
                        res.error = "Categoria Incorrecta";
                    }
                    else
                    {
                        int? returnId = 0;
                        int? errorId = 0;
                        string errorDescripcion = "";

                        using (ConexionLINQDataContext miLinq = new ConexionLINQDataContext())
                        {
                            miLinq.SP_ACTUALIZAR_PRODUCTO(req.producto.nombre_actual, req.producto.nuevo_nombre, req.producto.descripcion, req.producto.precio_producto, req.producto.nombre_categoria, ref returnId, ref errorId, ref errorDescripcion);

                            if (errorId == 0)
                            {
                                // Cierre de sesión exitoso
                                res.resultado = true;
                            }
                            else
                            {
                                // Cierre de sesión fallido
                                res.resultado = false;
                                res.error = string.IsNullOrEmpty(errorDescripcion) ? "Error al actualizando productos" : errorDescripcion;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                res.resultado = false;
                res.error = "500- Error Interno: " + ex.Message;
            }

            return res;
        }
        //listo

        public ResEliminarProducto eliminarProducto(ReqEliminarProducto req)
        {
            ResEliminarProducto res = new ResEliminarProducto();

            try
            {
                if (req == null)
                {
                    res.resultado = false;
                    res.error = "Bad request";
                }
                else
                {
                    if (String.IsNullOrEmpty(req.producto.nombre))
                    {
                        res.resultado = false;
                        res.error = "Nombre Incorrecto";

                    }
                    else
                    {
                        int? returnId = 0;
                        int? errorId = 0;
                        string errorDescripcion = "";

                        ConexionLINQDataContext miLinq = new ConexionLINQDataContext();
                        miLinq.SP_ELIMINAR_PRODUCTO(req.producto.nombre, ref returnId, ref errorId, ref errorDescripcion);
                        if (returnId <= 0 || returnId == null)
                        {

                            res.resultado = false;
                            res.error = errorDescripcion;
                        }
                        else
                        {
                            //todo paso bien

                            res.resultado = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                res.resultado = false;
                res.error = "500- Error Interno";
            }

            return res;
        }
        //listo

        public ResObtenerProductos obtenerProductos()
        {
            ResObtenerProductos res = new ResObtenerProductos();
            try
            {
                ConexionLINQDataContext miLinq = new ConexionLINQDataContext();

                List<SP_CONSULTAR_TODOS_PRODUCTOSResult> resultSet = new List<SP_CONSULTAR_TODOS_PRODUCTOSResult>();

                resultSet = miLinq.SP_CONSULTAR_TODOS_PRODUCTOS().ToList();

                foreach (SP_CONSULTAR_TODOS_PRODUCTOSResult unaPublicacionLinq in resultSet)
                {
                    res.listaDePublicaciones.Add(this.fabricaDePublicacion(unaPublicacionLinq));

                }
                res.resultado = true;
            }
            catch (Exception ex)
            {
                res.resultado = false;
                res.error = "Error en backend";
            }
            return res;
        }


        //factoria
        private Producto.ConsultarTodos fabricaDePublicacion(SP_CONSULTAR_TODOS_PRODUCTOSResult publicacionLinq) // este fue para obtener publicaciones
        {
            Producto.ConsultarTodos productoFabricado = new Producto.ConsultarTodos();
            productoFabricado.nombre_categoria = publicacionLinq.categoria_nombre;
            productoFabricado.nombre = publicacionLinq.producto_nombre;
            productoFabricado.descripcion = publicacionLinq.descripcion;
            productoFabricado.precio_producto = (int?)publicacionLinq.precio_producto;

            return productoFabricado;
        }
        //listo


        /// Todo Categoria listo
        public ResInsertarCategoria insertarCategoria(ReqInsertarCategoria req)
        {
            ResInsertarCategoria res = new ResInsertarCategoria();

            try
            {
                if (req == null)
                {
                    res.resultado = false;
                    res.error = "Bad request";
                }
                else
                {
                    if (String.IsNullOrEmpty(req.categoria.nombre))
                    {
                        res.resultado = false;
                        res.error = "Nombre Incorrecto";

                    }
                    else if (String.IsNullOrEmpty(req.categoria.descripcion))
                    {
                        res.resultado = false;
                        res.error = "descripcion Incorrecto";
                    }
                    else
                    {
                        int? returnId = 0;
                        int? errorId = 0;
                        string errorDescripcion = "";

                        ConexionLINQDataContext miLinq = new ConexionLINQDataContext();
                        miLinq.SP_INSERTAR_CATEGORIA(req.categoria.nombre, req.categoria.descripcion, ref returnId, ref errorId, ref errorDescripcion);
                        if (returnId <= 0 || returnId == null)
                        {

                            res.resultado = false;
                            res.error = errorDescripcion;
                        }
                        else
                        {
                            //todo paso bien

                            res.resultado = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                res.resultado = false;
                res.error = "500- Error Interno";
            }

            return res;
        }
        //listo

        public ResActualizarCategoria actualizarCategoria(ReqActualizarCategoria req)
        {
            ResActualizarCategoria res = new ResActualizarCategoria();

            try
            {
                if (req == null)
                {
                    res.resultado = false;
                    res.error = "Bad request";
                }
                else
                {
                    if (String.IsNullOrEmpty(req.categoria.nombre))
                    {
                        res.resultado = false;
                        res.error = "Nombre Incorrecto";

                    }
                    if (String.IsNullOrEmpty(req.categoria.nuevo_nombre))
                    {
                        res.resultado = false;
                        res.error = "Nombre Incorrecto";

                    }
                    else if (String.IsNullOrEmpty(req.categoria.nueva_descripcion))
                    {
                        res.resultado = false;
                        res.error = "descripcion Incorrecto";
                    }
                    else
                    {
                        int? returnId = 0;
                        int? errorId = 0;
                        string errorDescripcion = "";

                        ConexionLINQDataContext miLinq = new ConexionLINQDataContext();
                        miLinq.ActualizarCategoria(req.categoria.nombre, req.categoria.nuevo_nombre, req.categoria.nueva_descripcion, ref returnId, ref errorId, ref errorDescripcion);
                        if (returnId <= 0 || returnId == null)
                        {

                            res.resultado = false;
                            res.error = errorDescripcion;
                        }
                        else
                        {
                            //todo paso bien

                            res.resultado = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                res.resultado = false;
                res.error = "500- Error Interno";
            }

            return res;
        }
        //listo

        public ResEliminarCategoria eliminarCategoria(ReqEliminarCategoria req)
        {
            ResEliminarCategoria res = new ResEliminarCategoria();

            try
            {
                if (req == null)
                {
                    res.resultado = false;
                    res.error = "Bad request";
                }
                else
                {
                    if (String.IsNullOrEmpty(req.categoria.nombre))
                    {
                        res.resultado = false;
                        res.error = "Nombre Incorrecto";

                    }
                    else
                    {
                        int? returnId = 0;
                        int? errorId = 0;
                        string errorDescripcion = "";

                        ConexionLINQDataContext miLinq = new ConexionLINQDataContext();
                        miLinq.SP_ELIMINAR_CATEGORIA(req.categoria.nombre, ref returnId, ref errorId, ref errorDescripcion);
                        if (returnId <= 0 || returnId == null)
                        {

                            res.resultado = false;
                            res.error = errorDescripcion;
                        }
                        else
                        {
                            //todo paso bien

                            res.resultado = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                res.resultado = false;
                res.error = "500- Error Interno";
            }

            return res;
        }
        //listo


        /// Carrito

        public ResIngresaralCarrito ingresarCarrito(ReqIngresaralCarrito req)
        {
            ResIngresaralCarrito res = new ResIngresaralCarrito();

            try
            {
                if (req == null)
                {
                    res.resultado = false;
                    res.error = "Bad request";
                }
                else
                {
                    if (req.carrito.id_usuario == 0)
                    {
                        res.resultado = false;
                        res.error = "id Incorrecta";
                    }
                    if (String.IsNullOrEmpty(req.carrito.nombre_producto))
                    {
                        res.resultado = false;
                        res.error = "Nombre Incorrecto";

                    }
                    if (req.carrito.cantidad == 0)
                    {
                        res.resultado = false;
                        res.error = "id Incorrecta";
                    }

                    else
                    {
                        {
                            int? returnId = 0;
                            int? errorId = 0;
                            string errorDescripcion = "";

                            ConexionLINQDataContext miLinq = new ConexionLINQDataContext();
                            miLinq.SP_Ingresar_carrito(req.carrito.id_usuario, req.carrito.nombre_producto, req.carrito.cantidad, ref returnId, ref errorId, ref errorDescripcion);
                            if (errorId == 0)
                            {
                                // Producto agregado al carrito exitosamente
                                res.resultado = true;
                                res.error = null; // Limpia cualquier error previo
                            }
                            else
                            {
                                // Ocurrió un error al intentar agregar el producto al carrito
                                res.resultado = false;
                                res.error = $"Error {errorId}: {errorDescripcion}";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                res.resultado = false;
                res.error = "500- Error Interno" + ex.Message; ;
            }

            return res;
        }
        //listo

        public ResObtenerProductosCarrito obtenerProductosCarrito(ReqObtenerProductosCarrito req)
        {
            ResObtenerProductosCarrito res = new ResObtenerProductosCarrito();
            try
            {
                if (req.id_usuario <= 0)
                {
                    res.resultado = false;
                    res.error = "ID de usuario incorrecto";
                    return res;
                }

                using (var miLinq = new ConexionLINQDataContext())
                {
                    // Ejecutar el procedimiento almacenado con el id_usuario
                    List<sp_ObtenerProductosCarritoResult> resultSet = miLinq.sp_ObtenerProductosCarrito(req.id_usuario).ToList();

                    // Verificar si hay resultados y mapearlos
                    if (resultSet == null || !resultSet.Any())
                    {
                        res.resultado = false;
                        res.error = "No se encontraron productos en el carrito.";
                    }
                    else
                    {
                        res.listaDeconsultas = resultSet.Select(item => fabricaDeconsultas(item, req.id_usuario)).ToList();
                        res.resultado = true;
                    }
                }
            }
            catch (Exception ex)
            {
                res.resultado = false;
                res.error = "Error en backend: " + ex.Message;
            }
            return res;
        }

        // Función de fábrica
        private Carrito.consulta fabricaDeconsultas(sp_ObtenerProductosCarritoResult productoLinq, int id_usuario)
        {
            Carrito.consulta consultaFabricada = new Carrito.consulta();
            consultaFabricada.id_usuario = id_usuario;
            consultaFabricada.id_producto = productoLinq.id_producto;
            consultaFabricada.id_carrito = (int)productoLinq.id_carrito;
            consultaFabricada.nombre = productoLinq.nombre;
            consultaFabricada.descripcion = productoLinq.descripcion;
            consultaFabricada.precio_producto = productoLinq.precio_producto;
            consultaFabricada.fecha_agregado = productoLinq.fecha_agregado;
            consultaFabricada.cantidad = (int)productoLinq.cantidad;


            return consultaFabricada;
        }


        // Función de fábrica

        ///Tarjetas
        public ResIngresarTarjeta ingresarTarjeta(ReqIngresarTarjeta req)
        {
            ResIngresarTarjeta res = new ResIngresarTarjeta();

            try
            {
                if (req == null)
                {
                    res.resultado = false;
                    res.error = "Bad request";
                }
                else
                {
                    if (String.IsNullOrEmpty(req.tarjetas.numero_trajeta))
                    {
                        res.resultado = false;
                        res.error = "numero Incorrecto";
                    }
                    else if (String.IsNullOrEmpty(req.tarjetas.fecha_expiracion))
                    {
                        res.resultado = false;
                        res.error = "fecha Incorrecto";
                    }
                    else if (String.IsNullOrEmpty(req.tarjetas.CVV))
                    {
                        res.resultado = false;
                        res.error = "CVV Incorrecto";
                    }
                    if (req.tarjetas.id_usuario == 0)
                    {
                        res.resultado = false;
                        res.error = "id Incorrecta";
                    }
                    else
                    {
                        {
                            int? returnId = 0;
                            int? errorId = 0;
                            string errorDescripcion = "";


                            ConexionLINQDataContext miLinq = new ConexionLINQDataContext();
                            miLinq.SP_INGRESAR_TARJETA(req.tarjetas.numero_trajeta, req.tarjetas.fecha_expiracion, req.tarjetas.CVV, req.tarjetas.id_usuario, ref returnId, ref errorId, ref errorDescripcion);
                            if (errorId == 0)
                            {
                                // Cierre de sesión exitoso
                                res.resultado = true;
                            }
                            else
                            {
                                // Cierre de sesión fallido
                                res.resultado = false;
                                res.error = string.IsNullOrEmpty(errorDescripcion) ? "Error al cerrar sesión" : errorDescripcion;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                res.resultado = false;
                res.error = "500- Error Interno";
            }

            return res;
        }
        //listo
        public ResEliminarTarjeta eliminarTarjeta(ReqEliminarTarjeta req)
        {
            ResEliminarTarjeta res = new ResEliminarTarjeta();

            try
            {
                if (req == null)
                {
                    res.resultado = false;
                    res.error = "Bad request";
                }
                else
                {
                    if (String.IsNullOrEmpty(req.tarjetas.numero_trajeta))
                    {
                        res.resultado = false;
                        res.error = "numero Incorrecto";
                    }
                    else
                    {
                        {
                            int? returnId = 0;
                            int? errorId = 0;
                            string errorDescripcion = "";


                            ConexionLINQDataContext miLinq = new ConexionLINQDataContext();
                            miLinq.SP_ELIMINAR_TARJETA_POR_NUMERO(req.tarjetas.numero_trajeta, ref errorId, ref errorDescripcion);
                            if (errorId == 0)
                            {
                                // Cierre de sesión exitoso
                                res.resultado = true;
                            }
                            else
                            {
                                // Cierre de sesión fallido
                                res.resultado = false;
                                res.error = string.IsNullOrEmpty(errorDescripcion) ? "Error al cerrar sesión" : errorDescripcion;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                res.resultado = false;
                res.error = "500- Error Interno";
            }

            return res;
        }
        //listo
        public ResActualizarTarjeta actualizarTarjeta(ReqActualizarTarjeta req)
        {
            ResActualizarTarjeta res = new ResActualizarTarjeta();

            try
            {
                if (req == null)
                {
                    res.resultado = false;
                    res.error = "Bad request";
                }
                else
                {
                    if (String.IsNullOrEmpty(req.tarjetas.nuevo_numero_trajeta))
                    {
                        res.resultado = false;
                        res.error = "Nombre Incorrecto";
                    }
                    else if (String.IsNullOrEmpty(req.tarjetas.nuevo_numero_trajeta))
                    {
                        res.resultado = false;
                        res.error = "Nombre Incorrecto";
                    }
                    else if (String.IsNullOrEmpty(req.tarjetas.nueva_fecha_expiracion))
                    {
                        res.resultado = false;
                        res.error = "Nombre Incorrecto";
                    }
                    else if (String.IsNullOrEmpty(req.tarjetas.nuevo_CVV))
                    {
                        res.resultado = false;
                        res.error = "Nombre Incorrecto";
                    }
                    else
                    {
                        {
                            int? errorId = 0;
                            string errorDescripcion = "";


                            ConexionLINQDataContext miLinq = new ConexionLINQDataContext();
                            miLinq.SP_ACTUALIZAR_TARJETA_POR_NUMERO(req.tarjetas.numero_trajeta, req.tarjetas.nuevo_numero_trajeta, req.tarjetas.nueva_fecha_expiracion, req.tarjetas.nuevo_CVV, ref errorId, ref errorDescripcion);
                            if (errorId == 0)
                            {
                                // Cierre de sesión exitoso
                                res.resultado = true;
                            }
                            else
                            {
                                // Cierre de sesión fallido
                                res.resultado = false;
                                res.error = string.IsNullOrEmpty(errorDescripcion) ? "Error al cerrar sesión" : errorDescripcion;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                res.resultado = false;
                res.error = "500- Error Interno";
            }

            return res;
        }
        //listo


        /// ////////////////////////////////FACTURA

        public ResConsultaFactura generarFactura(ReqConsultaFactura req)
        {
            ResConsultaFactura res = new ResConsultaFactura();
            try
            {
                if (req.id_usuario <= 0)
                {
                    res.resultado = false;
                    res.error = "ID de usuario incorrecto";
                    return res;
                }
                if (req.id_tarjeta <= 0)
                {
                    res.resultado = false;
                    res.error = "ID de tarjeta incorrecto";
                    return res;
                }

                using (var miLinq = new ConexionLINQDataContext())
                {
                    // Ejecutar el procedimiento almacenado con id_usuario y id_tarjeta
                    List<SP_GENERAR_FACTURAResult> resultSet = miLinq.SP_GENERAR_FACTURA(req.id_usuario, req.id_tarjeta).ToList();

                    // Verificar si hay resultados y mapearlos
                    if (resultSet == null || !resultSet.Any())
                    {
                        res.resultado = false;
                        res.error = "No se encontraron productos en el carrito.";
                    }
                    else
                    {
                        res.listaDefacturas = resultSet
                            .Select(item => fabricaDefacturas(item, req.id_usuario, req.id_tarjeta))
                            .ToList();
                        res.resultado = true;
                    }
                }
            }
            catch (Exception ex)
            {
                res.resultado = false;
                res.error = "Error en backend: " + ex.Message;
            }
            return res;
        }


        // Función de fábrica
        private Factura.Consultar fabricaDefacturas(SP_GENERAR_FACTURAResult productoLinq, int id_usuario, int id_tarjeta)
        {
            Factura.Consultar consultaFabricada = new Factura.Consultar();
            consultaFabricada.id_usuario = id_usuario;
            consultaFabricada.id_tarjeta = id_tarjeta;
            consultaFabricada.id_factura = productoLinq.id_factura;
            consultaFabricada.fecha = productoLinq.fecha;
            consultaFabricada.nombre_usuario = productoLinq.nombre_usuario;
            consultaFabricada.cedula = productoLinq.cedula;
            consultaFabricada.nombre_producto = productoLinq.nombre_producto;
            consultaFabricada.precio_producto = (int)productoLinq.precio_producto;
            consultaFabricada.cantidad = (int)productoLinq.cantidad;
            consultaFabricada.subtotal = (int)productoLinq.subtotal;
            consultaFabricada.monto_total = (int)productoLinq.monto_total;

            return consultaFabricada;
        }

        public ResEliminarProductodelCarrito eliminarProductoCarrito(ReqEliminarProductodelCarrito req)
        {
            ResEliminarProductodelCarrito res = new ResEliminarProductodelCarrito();

            try
            {
                if (req == null)
                {
                    res.resultado = false;
                    res.error = "Bad request";
                }
                else
                {
                    if (req.carrito.id_usuario == 0)
                    {
                        res.resultado = false;
                        res.error = "id Incorrecta";
                    }
                    if (req.carrito.id_carrito == 0)
                    {
                        res.resultado = false;
                        res.error = "id Incorrecta";
                    }

                    else
                    {
                        {
                            int? returnId = 0;
                            int? errorId = 0;
                            string errorDescripcion = "";

                            ConexionLINQDataContext miLinq = new ConexionLINQDataContext();
                            miLinq.SP_Eliminar_Producto_Carrito(req.carrito.id_carrito, req.carrito.id_usuario, ref returnId, ref errorId, ref errorDescripcion);
                            if (errorId == 0)
                            {
                                // Producto agregado al carrito exitosamente
                                res.resultado = true;
                                res.error = null; // Limpia cualquier error previo
                            }
                            else
                            {
                                // Ocurrió un error al intentar agregar el producto al carrito
                                res.resultado = false;
                                res.error = $"Error {errorId}: {errorDescripcion}";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                res.resultado = false;
                res.error = "500- Error Interno" + ex.Message; ;
            }

            return res;
        }
        public ResObtenerTarjetas obtenerTarjetas(ReqObtenerTarjetas req)

        {

            ResObtenerTarjetas res = new ResObtenerTarjetas();

            try

            {

                if (req.id_usuario <= 0)

                {

                    res.resultado = false;

                    res.error = "ID de usuario incorrecto";

                    return res;

                }

                using (var miLinq = new ConexionLINQDataContext())

                {

                    // Ejecutar el procedimiento almacenado con el id_usuario

                    List<SP_OBTENER_TARJETASResult> resultSet = miLinq.SP_OBTENER_TARJETAS(req.id_usuario).ToList();

                    // Verificar si hay resultados y mapearlos

                    if (resultSet == null || !resultSet.Any())

                    {

                        res.resultado = false;

                        res.error = "No se encontraron tarjetas";

                    }

                    else

                    {

                        res.listaDeconsultas = resultSet.Select(item => fabricaDetarjetas(item, req.id_usuario)).ToList();

                        res.resultado = true;

                    }

                }

            }

            catch (Exception ex)

            {

                res.resultado = false;

                res.error = "Error en backend: " + ex.Message;

            }

            return res;

        }

        //factoria

        private Tarjetas.consultaTarjeta fabricaDetarjetas(SP_OBTENER_TARJETASResult publicacionLinq, int id_usuario)

        {

            Tarjetas.consultaTarjeta consultadaFabricado = new Tarjetas.consultaTarjeta();

            consultadaFabricado.id_usuario = id_usuario;

            consultadaFabricado.id_tarjeta = publicacionLinq.id_tarjeta;

            consultadaFabricado.numero_trajeta = publicacionLinq.numero_tarjeta;

            consultadaFabricado.fecha_expiracion = publicacionLinq.fecha_expiracion;

            consultadaFabricado.CVV = publicacionLinq.CVV;

            return consultadaFabricado;

        }

    }
}

