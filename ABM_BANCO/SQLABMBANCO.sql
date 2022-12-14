USE [BANCO]
GO
/****** Object:  StoredProcedure [dbo].[listadoClientes]    Script Date: 21/8/2022 20:04:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[listadoClientes]
as
select cl.id_cliente, cl.nombre, cl.apellido, cl.dni, c.cbu, c.saldo, c.ultimoMovimiento, tc.nombre from clientes cl
join CUENTAS c on c.id_cliente=cl.id_cliente
join TIPOCUENTAS tc on tc.id_tipoCuenta=c.id_tipoCuenta
order by 1

execute listadoClientes