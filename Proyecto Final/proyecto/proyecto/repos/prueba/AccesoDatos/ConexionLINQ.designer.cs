﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace prueba.AccesoDatos
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ProyectoDB")]
	public partial class ConexionLINQDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public ConexionLINQDataContext() : 
				base(global::prueba.Properties.Settings.Default.ProyectoDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ConexionLINQDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConexionLINQDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConexionLINQDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConexionLINQDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ActualizarCategoria")]
		public int ActualizarCategoria([global::System.Data.Linq.Mapping.ParameterAttribute(Name="NOMBRE", DbType="NVarChar(100)")] string nOMBRE, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NUEVO_NOMBRE", DbType="NVarChar(100)")] string nUEVO_NOMBRE, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NUEVA_DESCRIPCION", DbType="NVarChar(100)")] string nUEVA_DESCRIPCION, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDRETURN", DbType="Int")] ref System.Nullable<int> iDRETURN, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORID", DbType="Int")] ref System.Nullable<int> eRRORID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORDESCRIPCION", DbType="NVarChar(MAX)")] ref string eRRORDESCRIPCION)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nOMBRE, nUEVO_NOMBRE, nUEVA_DESCRIPCION, iDRETURN, eRRORID, eRRORDESCRIPCION);
			iDRETURN = ((System.Nullable<int>)(result.GetParameterValue(3)));
			eRRORID = ((System.Nullable<int>)(result.GetParameterValue(4)));
			eRRORDESCRIPCION = ((string)(result.GetParameterValue(5)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_ACTUALIZAR_PRODUCTO")]
		public int SP_ACTUALIZAR_PRODUCTO([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(100)")] string nombre_actual, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(100)")] string nuevo_nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(MAX)")] string descripcion, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(18,2)")] System.Nullable<decimal> precio_producto, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(100)")] string nombre_categoria, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDRETURN", DbType="Int")] ref System.Nullable<int> iDRETURN, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORID", DbType="Int")] ref System.Nullable<int> eRRORID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORDESCRIPCION", DbType="NVarChar(MAX)")] ref string eRRORDESCRIPCION)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nombre_actual, nuevo_nombre, descripcion, precio_producto, nombre_categoria, iDRETURN, eRRORID, eRRORDESCRIPCION);
			iDRETURN = ((System.Nullable<int>)(result.GetParameterValue(5)));
			eRRORID = ((System.Nullable<int>)(result.GetParameterValue(6)));
			eRRORDESCRIPCION = ((string)(result.GetParameterValue(7)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_ACTUALIZAR_TARJETA_POR_NUMERO")]
		public int SP_ACTUALIZAR_TARJETA_POR_NUMERO([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(16)")] string numero_tarjeta, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(16)")] string nuevo_numero_tarjeta, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(10)")] string nueva_fecha_expiracion, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(5)")] string nuevo_CVV, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORID", DbType="Int")] ref System.Nullable<int> eRRORID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORDESCRIPCION", DbType="NVarChar(MAX)")] ref string eRRORDESCRIPCION)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), numero_tarjeta, nuevo_numero_tarjeta, nueva_fecha_expiracion, nuevo_CVV, eRRORID, eRRORDESCRIPCION);
			eRRORID = ((System.Nullable<int>)(result.GetParameterValue(4)));
			eRRORDESCRIPCION = ((string)(result.GetParameterValue(5)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_ACTUALIZAR_USUARIO")]
		public int SP_ACTUALIZAR_USUARIO([global::System.Data.Linq.Mapping.ParameterAttribute(Name="CEDULA", DbType="NVarChar(20)")] string cEDULA, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NOMBRE", DbType="NVarChar(100)")] string nOMBRE, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="EMAIL", DbType="NVarChar(100)")] string eMAIL, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PASSWORD", DbType="VarChar(255)")] string pASSWORD, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDRETURN", DbType="Int")] ref System.Nullable<int> iDRETURN, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORID", DbType="Int")] ref System.Nullable<int> eRRORID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORDESCRIPCION", DbType="NVarChar(MAX)")] ref string eRRORDESCRIPCION)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), cEDULA, nOMBRE, eMAIL, pASSWORD, iDRETURN, eRRORID, eRRORDESCRIPCION);
			iDRETURN = ((System.Nullable<int>)(result.GetParameterValue(4)));
			eRRORID = ((System.Nullable<int>)(result.GetParameterValue(5)));
			eRRORDESCRIPCION = ((string)(result.GetParameterValue(6)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_AGREGAR_PRODUCTO")]
		public int SP_AGREGAR_PRODUCTO([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(100)")] string nombre_categoria, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(100)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(MAX)")] string descripcion, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(18,2)")] System.Nullable<decimal> precio_producto, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDRETURN", DbType="Int")] ref System.Nullable<int> iDRETURN, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORID", DbType="Int")] ref System.Nullable<int> eRRORID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORDESCRIPCION", DbType="NVarChar(MAX)")] ref string eRRORDESCRIPCION)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nombre_categoria, nombre, descripcion, precio_producto, iDRETURN, eRRORID, eRRORDESCRIPCION);
			iDRETURN = ((System.Nullable<int>)(result.GetParameterValue(4)));
			eRRORID = ((System.Nullable<int>)(result.GetParameterValue(5)));
			eRRORDESCRIPCION = ((string)(result.GetParameterValue(6)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_CERRAR_SESION")]
		public int SP_CERRAR_SESION([global::System.Data.Linq.Mapping.ParameterAttribute(Name="SESION_ID", DbType="BigInt")] System.Nullable<long> sESION_ID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDRETURN", DbType="Int")] ref System.Nullable<int> iDRETURN, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORID", DbType="Int")] ref System.Nullable<int> eRRORID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORDESCRIPCION", DbType="NVarChar(MAX)")] ref string eRRORDESCRIPCION)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), sESION_ID, iDRETURN, eRRORID, eRRORDESCRIPCION);
			iDRETURN = ((System.Nullable<int>)(result.GetParameterValue(1)));
			eRRORID = ((System.Nullable<int>)(result.GetParameterValue(2)));
			eRRORDESCRIPCION = ((string)(result.GetParameterValue(3)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_CONSULTAR_TODOS_PRODUCTOS")]
		public ISingleResult<SP_CONSULTAR_TODOS_PRODUCTOSResult> SP_CONSULTAR_TODOS_PRODUCTOS()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SP_CONSULTAR_TODOS_PRODUCTOSResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_ELIMINAR_CATEGORIA")]
		public int SP_ELIMINAR_CATEGORIA([global::System.Data.Linq.Mapping.ParameterAttribute(Name="NOMBRE", DbType="NVarChar(100)")] string nOMBRE, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDRETURN", DbType="Int")] ref System.Nullable<int> iDRETURN, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORID", DbType="Int")] ref System.Nullable<int> eRRORID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORDESCRIPCION", DbType="NVarChar(MAX)")] ref string eRRORDESCRIPCION)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nOMBRE, iDRETURN, eRRORID, eRRORDESCRIPCION);
			iDRETURN = ((System.Nullable<int>)(result.GetParameterValue(1)));
			eRRORID = ((System.Nullable<int>)(result.GetParameterValue(2)));
			eRRORDESCRIPCION = ((string)(result.GetParameterValue(3)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_ELIMINAR_PRODUCTO")]
		public int SP_ELIMINAR_PRODUCTO([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(100)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDRETURN", DbType="Int")] ref System.Nullable<int> iDRETURN, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORID", DbType="Int")] ref System.Nullable<int> eRRORID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORDESCRIPCION", DbType="NVarChar(MAX)")] ref string eRRORDESCRIPCION)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nombre, iDRETURN, eRRORID, eRRORDESCRIPCION);
			iDRETURN = ((System.Nullable<int>)(result.GetParameterValue(1)));
			eRRORID = ((System.Nullable<int>)(result.GetParameterValue(2)));
			eRRORDESCRIPCION = ((string)(result.GetParameterValue(3)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_Eliminar_Producto_Carrito")]
		public int SP_Eliminar_Producto_Carrito([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> id_carrito, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> id_usuario, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDRETURN", DbType="Int")] ref System.Nullable<int> iDRETURN, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORID", DbType="Int")] ref System.Nullable<int> eRRORID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORDESCRIPCION", DbType="NVarChar(MAX)")] ref string eRRORDESCRIPCION)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id_carrito, id_usuario, iDRETURN, eRRORID, eRRORDESCRIPCION);
			iDRETURN = ((System.Nullable<int>)(result.GetParameterValue(2)));
			eRRORID = ((System.Nullable<int>)(result.GetParameterValue(3)));
			eRRORDESCRIPCION = ((string)(result.GetParameterValue(4)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_ELIMINAR_TARJETA_POR_NUMERO")]
		public int SP_ELIMINAR_TARJETA_POR_NUMERO([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(16)")] string numero_tarjeta, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORID", DbType="Int")] ref System.Nullable<int> eRRORID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORDESCRIPCION", DbType="NVarChar(MAX)")] ref string eRRORDESCRIPCION)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), numero_tarjeta, eRRORID, eRRORDESCRIPCION);
			eRRORID = ((System.Nullable<int>)(result.GetParameterValue(1)));
			eRRORDESCRIPCION = ((string)(result.GetParameterValue(2)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_ELIMINAR_USUARIO")]
		public int SP_ELIMINAR_USUARIO([global::System.Data.Linq.Mapping.ParameterAttribute(Name="CEDULA", DbType="NVarChar(20)")] string cEDULA, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDRETURN", DbType="Int")] ref System.Nullable<int> iDRETURN, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORID", DbType="Int")] ref System.Nullable<int> eRRORID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORDESCRIPCION", DbType="NVarChar(MAX)")] ref string eRRORDESCRIPCION)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), cEDULA, iDRETURN, eRRORID, eRRORDESCRIPCION);
			iDRETURN = ((System.Nullable<int>)(result.GetParameterValue(1)));
			eRRORID = ((System.Nullable<int>)(result.GetParameterValue(2)));
			eRRORDESCRIPCION = ((string)(result.GetParameterValue(3)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_GENERAR_FACTURA")]
		public ISingleResult<SP_GENERAR_FACTURAResult> SP_GENERAR_FACTURA([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> id_usuario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> id_tarjeta)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id_usuario, id_tarjeta);
			return ((ISingleResult<SP_GENERAR_FACTURAResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_Ingresar_carrito")]
		public int SP_Ingresar_carrito([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> id_usuario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(100)")] string nombre_producto, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> cantidad, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDRETURN", DbType="Int")] ref System.Nullable<int> iDRETURN, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORID", DbType="Int")] ref System.Nullable<int> eRRORID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORDESCRIPCION", DbType="NVarChar(MAX)")] ref string eRRORDESCRIPCION)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id_usuario, nombre_producto, cantidad, iDRETURN, eRRORID, eRRORDESCRIPCION);
			iDRETURN = ((System.Nullable<int>)(result.GetParameterValue(3)));
			eRRORID = ((System.Nullable<int>)(result.GetParameterValue(4)));
			eRRORDESCRIPCION = ((string)(result.GetParameterValue(5)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_INGRESAR_TARJETA")]
		public int SP_INGRESAR_TARJETA([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(16)")] string numero_tarjeta, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(MAX)")] string fecha_expiracion, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="CVV", DbType="NVarChar(5)")] string cVV, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> id_usuario, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDRETURN", DbType="Int")] ref System.Nullable<int> iDRETURN, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORID", DbType="Int")] ref System.Nullable<int> eRRORID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORDESCRIPCION", DbType="NVarChar(MAX)")] ref string eRRORDESCRIPCION)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), numero_tarjeta, fecha_expiracion, cVV, id_usuario, iDRETURN, eRRORID, eRRORDESCRIPCION);
			iDRETURN = ((System.Nullable<int>)(result.GetParameterValue(4)));
			eRRORID = ((System.Nullable<int>)(result.GetParameterValue(5)));
			eRRORDESCRIPCION = ((string)(result.GetParameterValue(6)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_INGRESAR_USUARIO")]
		public int SP_INGRESAR_USUARIO([global::System.Data.Linq.Mapping.ParameterAttribute(Name="CEDULA", DbType="NVarChar(20)")] string cEDULA, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NOMBRE", DbType="NVarChar(100)")] string nOMBRE, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="EMAIL", DbType="NVarChar(100)")] string eMAIL, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PASSWORD", DbType="VarChar(255)")] string pASSWORD, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDRETURN", DbType="Int")] ref System.Nullable<int> iDRETURN, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORID", DbType="Int")] ref System.Nullable<int> eRRORID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORDESCRIPCION", DbType="NVarChar(MAX)")] ref string eRRORDESCRIPCION)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), cEDULA, nOMBRE, eMAIL, pASSWORD, iDRETURN, eRRORID, eRRORDESCRIPCION);
			iDRETURN = ((System.Nullable<int>)(result.GetParameterValue(4)));
			eRRORID = ((System.Nullable<int>)(result.GetParameterValue(5)));
			eRRORDESCRIPCION = ((string)(result.GetParameterValue(6)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_INSERTAR_CATEGORIA")]
		public int SP_INSERTAR_CATEGORIA([global::System.Data.Linq.Mapping.ParameterAttribute(Name="NOMBRE", DbType="NVarChar(100)")] string nOMBRE, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DESCRIPCION", DbType="NVarChar(100)")] string dESCRIPCION, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDRETURN", DbType="Int")] ref System.Nullable<int> iDRETURN, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORID", DbType="Int")] ref System.Nullable<int> eRRORID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORDESCRIPCION", DbType="NVarChar(MAX)")] ref string eRRORDESCRIPCION)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nOMBRE, dESCRIPCION, iDRETURN, eRRORID, eRRORDESCRIPCION);
			iDRETURN = ((System.Nullable<int>)(result.GetParameterValue(2)));
			eRRORID = ((System.Nullable<int>)(result.GetParameterValue(3)));
			eRRORDESCRIPCION = ((string)(result.GetParameterValue(4)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_LOGIN_USUARIO")]
		public int SP_LOGIN_USUARIO([global::System.Data.Linq.Mapping.ParameterAttribute(Name="EMAIL", DbType="NVarChar(100)")] string eMAIL, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PASSWORD", DbType="VarChar(255)")] string pASSWORD, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SESION_ID", DbType="BigInt")] ref System.Nullable<long> sESION_ID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID_USUARIO", DbType="Int")] ref System.Nullable<int> iD_USUARIO, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORID", DbType="Int")] ref System.Nullable<int> eRRORID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORDESCRIPCION", DbType="NVarChar(MAX)")] ref string eRRORDESCRIPCION)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), eMAIL, pASSWORD, sESION_ID, iD_USUARIO, eRRORID, eRRORDESCRIPCION);
			sESION_ID = ((System.Nullable<long>)(result.GetParameterValue(2)));
			iD_USUARIO = ((System.Nullable<int>)(result.GetParameterValue(3)));
			eRRORID = ((System.Nullable<int>)(result.GetParameterValue(4)));
			eRRORDESCRIPCION = ((string)(result.GetParameterValue(5)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_OBTENER_TARJETAS")]
		public ISingleResult<SP_OBTENER_TARJETASResult> SP_OBTENER_TARJETAS([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> id_usuario)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id_usuario);
			return ((ISingleResult<SP_OBTENER_TARJETASResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_ObtenerProductosCarrito")]
		public ISingleResult<sp_ObtenerProductosCarritoResult> sp_ObtenerProductosCarrito([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> id_usuario)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id_usuario);
			return ((ISingleResult<sp_ObtenerProductosCarritoResult>)(result.ReturnValue));
		}
	}
	
	public partial class SP_CONSULTAR_TODOS_PRODUCTOSResult
	{
		
		private int _id_producto;
		
		private string _categoria_nombre;
		
		private string _producto_nombre;
		
		private string _descripcion;
		
		private decimal _precio_producto;
		
		private System.DateTime _fecha_agregado;
		
		public SP_CONSULTAR_TODOS_PRODUCTOSResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_producto", DbType="Int NOT NULL")]
		public int id_producto
		{
			get
			{
				return this._id_producto;
			}
			set
			{
				if ((this._id_producto != value))
				{
					this._id_producto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_categoria_nombre", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string categoria_nombre
		{
			get
			{
				return this._categoria_nombre;
			}
			set
			{
				if ((this._categoria_nombre != value))
				{
					this._categoria_nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_producto_nombre", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string producto_nombre
		{
			get
			{
				return this._producto_nombre;
			}
			set
			{
				if ((this._producto_nombre != value))
				{
					this._producto_nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_descripcion", DbType="NVarChar(MAX)")]
		public string descripcion
		{
			get
			{
				return this._descripcion;
			}
			set
			{
				if ((this._descripcion != value))
				{
					this._descripcion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_precio_producto", DbType="Decimal(18,2) NOT NULL")]
		public decimal precio_producto
		{
			get
			{
				return this._precio_producto;
			}
			set
			{
				if ((this._precio_producto != value))
				{
					this._precio_producto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fecha_agregado", DbType="DateTime NOT NULL")]
		public System.DateTime fecha_agregado
		{
			get
			{
				return this._fecha_agregado;
			}
			set
			{
				if ((this._fecha_agregado != value))
				{
					this._fecha_agregado = value;
				}
			}
		}
	}
	
	public partial class SP_GENERAR_FACTURAResult
	{
		
		private int _id_factura;
		
		private System.DateTime _fecha;
		
		private string _nombre_usuario;
		
		private string _cedula;
		
		private string _nombre_producto;
		
		private decimal _precio_producto;
		
		private int _cantidad;
		
		private System.Nullable<decimal> _subtotal;
		
		private System.Nullable<decimal> _monto_total;
		
		public SP_GENERAR_FACTURAResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_factura", DbType="Int NOT NULL")]
		public int id_factura
		{
			get
			{
				return this._id_factura;
			}
			set
			{
				if ((this._id_factura != value))
				{
					this._id_factura = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fecha", DbType="DateTime NOT NULL")]
		public System.DateTime fecha
		{
			get
			{
				return this._fecha;
			}
			set
			{
				if ((this._fecha != value))
				{
					this._fecha = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre_usuario", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string nombre_usuario
		{
			get
			{
				return this._nombre_usuario;
			}
			set
			{
				if ((this._nombre_usuario != value))
				{
					this._nombre_usuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cedula", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string cedula
		{
			get
			{
				return this._cedula;
			}
			set
			{
				if ((this._cedula != value))
				{
					this._cedula = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre_producto", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string nombre_producto
		{
			get
			{
				return this._nombre_producto;
			}
			set
			{
				if ((this._nombre_producto != value))
				{
					this._nombre_producto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_precio_producto", DbType="Decimal(18,2) NOT NULL")]
		public decimal precio_producto
		{
			get
			{
				return this._precio_producto;
			}
			set
			{
				if ((this._precio_producto != value))
				{
					this._precio_producto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cantidad", DbType="Int NOT NULL")]
		public int cantidad
		{
			get
			{
				return this._cantidad;
			}
			set
			{
				if ((this._cantidad != value))
				{
					this._cantidad = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_subtotal", DbType="Decimal(29,2)")]
		public System.Nullable<decimal> subtotal
		{
			get
			{
				return this._subtotal;
			}
			set
			{
				if ((this._subtotal != value))
				{
					this._subtotal = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_monto_total", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> monto_total
		{
			get
			{
				return this._monto_total;
			}
			set
			{
				if ((this._monto_total != value))
				{
					this._monto_total = value;
				}
			}
		}
	}
	
	public partial class SP_OBTENER_TARJETASResult
	{
		
		private int _id_tarjeta;
		
		private string _numero_tarjeta;
		
		private System.DateTime _fecha_expiracion;
		
		private string _CVV;
		
		private string _nombre_usuario;
		
		private string _cedula;
		
		public SP_OBTENER_TARJETASResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_tarjeta", DbType="Int NOT NULL")]
		public int id_tarjeta
		{
			get
			{
				return this._id_tarjeta;
			}
			set
			{
				if ((this._id_tarjeta != value))
				{
					this._id_tarjeta = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_numero_tarjeta", DbType="NVarChar(16) NOT NULL", CanBeNull=false)]
		public string numero_tarjeta
		{
			get
			{
				return this._numero_tarjeta;
			}
			set
			{
				if ((this._numero_tarjeta != value))
				{
					this._numero_tarjeta = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fecha_expiracion", DbType="DateTime NOT NULL")]
		public System.DateTime fecha_expiracion
		{
			get
			{
				return this._fecha_expiracion;
			}
			set
			{
				if ((this._fecha_expiracion != value))
				{
					this._fecha_expiracion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CVV", DbType="NVarChar(5) NOT NULL", CanBeNull=false)]
		public string CVV
		{
			get
			{
				return this._CVV;
			}
			set
			{
				if ((this._CVV != value))
				{
					this._CVV = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre_usuario", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string nombre_usuario
		{
			get
			{
				return this._nombre_usuario;
			}
			set
			{
				if ((this._nombre_usuario != value))
				{
					this._nombre_usuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cedula", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string cedula
		{
			get
			{
				return this._cedula;
			}
			set
			{
				if ((this._cedula != value))
				{
					this._cedula = value;
				}
			}
		}
	}
	
	public partial class sp_ObtenerProductosCarritoResult
	{
		
		private int _id_producto;
		
		private string _nombre;
		
		private string _descripcion;
		
		private decimal _precio_producto;
		
		private System.DateTime _fecha_agregado;
		
		private int _cantidad;
		
		private int _id_carrito;
		
		public sp_ObtenerProductosCarritoResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_producto", DbType="Int NOT NULL")]
		public int id_producto
		{
			get
			{
				return this._id_producto;
			}
			set
			{
				if ((this._id_producto != value))
				{
					this._id_producto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this._nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_descripcion", DbType="NVarChar(MAX)")]
		public string descripcion
		{
			get
			{
				return this._descripcion;
			}
			set
			{
				if ((this._descripcion != value))
				{
					this._descripcion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_precio_producto", DbType="Decimal(18,2) NOT NULL")]
		public decimal precio_producto
		{
			get
			{
				return this._precio_producto;
			}
			set
			{
				if ((this._precio_producto != value))
				{
					this._precio_producto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fecha_agregado", DbType="DateTime NOT NULL")]
		public System.DateTime fecha_agregado
		{
			get
			{
				return this._fecha_agregado;
			}
			set
			{
				if ((this._fecha_agregado != value))
				{
					this._fecha_agregado = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cantidad", DbType="Int NOT NULL")]
		public int cantidad
		{
			get
			{
				return this._cantidad;
			}
			set
			{
				if ((this._cantidad != value))
				{
					this._cantidad = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_carrito", DbType="Int NOT NULL")]
		public int id_carrito
		{
			get
			{
				return this._id_carrito;
			}
			set
			{
				if ((this._id_carrito != value))
				{
					this._id_carrito = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
