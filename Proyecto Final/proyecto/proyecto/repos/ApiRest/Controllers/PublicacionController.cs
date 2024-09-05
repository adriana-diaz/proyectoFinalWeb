﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using prueba.Logica;
using prueba.Modelos.Response;
using prueba.Modelos.Entidades;
using prueba.Modelos.Request;

namespace ApiRest.Controllers
{
    public class PublicacionController : ApiController
    {
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/usuario/ingresarusuario")]
        public ResInsertarUsuario insertarUsuario(ReqInsertarUsuario req)
        {
            return new LogProyecto().insertarUsuario(req);

        }

        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/usuario/actualizarusuario")]
        public ResActualizarUsuario actualizarUsuario(ReqActualizarUsuario req)
        {
            return new LogProyecto().actualizarUsuario(req);

        }

        [System.Web.Http.HttpDelete]
        [System.Web.Http.Route("api/usuario/Eliminarusuario")]
        public ResEliminarUsuario eliminarUsuario(ReqEliminarUsuario req)
        {
            return new LogProyecto().eliminarUsuario(req);

        }
        ///////////////////////////////////////////////////////////////////////////
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/login/entrarlogin")]
        public ResLogin entrarlogin(ReqLogin req)
        {
            return new LogProyecto().entrarlogin(req);
        }

        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/login/salirlogin")]
        public ResSalirLogin salirlogin(ReqSalirLogin req)
        {
            return new LogProyecto().salirlogin(req);
        }
        /////////////////////////////////////////////////////////////////////////
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/producto/agregarproducto")]
        public ResAgregarProducto agregarProducto(ReqAgregarProducto req)
        {
            return new LogProyecto().agregarProducto(req);

        }

        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/producto/actualizarproducto")]
        public ResActualizarProducto actualizarProducto(ReqActualizarProducto req)
        {
            return new LogProyecto().actualizarProducto(req);

        }
        [System.Web.Http.HttpDelete]
        [System.Web.Http.Route("api/producto/eliminarproducto")]
        public ResEliminarProducto eliminarProducto(ReqEliminarProducto req)
        {
            return new LogProyecto().eliminarProducto(req);

        }
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/producto/consultarproductos")]
        public ResObtenerProductos obtenerProductos()
        {
            return new LogProyecto().obtenerProductos();

        }
        /////////////////////////////////////////////////////////////////////////
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/categoria/ingresarcategoria")]
        public ResInsertarCategoria insertarCategoria(ReqInsertarCategoria req)
        {
            return new LogProyecto().insertarCategoria(req);

        }
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/categoria/actualizarcategoria")]
        public ResActualizarCategoria actualizarCategoria(ReqActualizarCategoria req)
        {
            return new LogProyecto().actualizarCategoria(req);

        }
        [System.Web.Http.HttpDelete]
        [System.Web.Http.Route("api/categoria/eliminarcategoria")]
        public ResEliminarCategoria eliminarCategoria(ReqEliminarCategoria req)
        {
            return new LogProyecto().eliminarCategoria(req);

        }
        //////////////////////////////////////////////////////////////////////////////
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/carrito/ingresarCarrito")]
        public ResIngresaralCarrito ingresarCarrito(ReqIngresaralCarrito req)
        {
            return new LogProyecto().ingresarCarrito(req);

        }
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/carrito/consultandoCarrito")]
        public ResObtenerProductosCarrito obtenerProductosCarrito(ReqObtenerProductosCarrito req)
        {
            return new LogProyecto().obtenerProductosCarrito(req);

        }
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/carrito/eliminarProductodelCarrito")]
        public ResEliminarProductodelCarrito eliminarProductoCarrito(ReqEliminarProductodelCarrito req)
        {
            return new LogProyecto().eliminarProductoCarrito(req);

        }

        //////////////////////////////////////////////////////////////////////////////
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/tarjeta/ingresarTarjetas")]
        public ResIngresarTarjeta ingresarTarjeta(ReqIngresarTarjeta req)
        {
            return new LogProyecto().ingresarTarjeta(req);

        }
        [System.Web.Http.HttpDelete]
        [System.Web.Http.Route("api/tarjeta/eliminarTarjetas")]
        public ResEliminarTarjeta eliminarTarjeta(ReqEliminarTarjeta req)
        {
            return new LogProyecto().eliminarTarjeta(req);

        }
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/tarjeta/actualizarTarjetas")]
        public ResActualizarTarjeta actualizarTarjeta(ReqActualizarTarjeta req)
        {
            return new LogProyecto().actualizarTarjeta(req);

        }
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/tarjeta/consultandotarjetas")]
        public ResObtenerTarjetas obtenerTarjetas(ReqObtenerTarjetas req)
        {
            return new LogProyecto().obtenerTarjetas(req);

        }

        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/factura/consultandoFactura")]
        public ResConsultaFactura generarFactura(ReqConsultaFactura req)
        {
            return new LogProyecto().generarFactura(req);
        }

        ///////////////////////////////////////////////////////////////////

    }
}