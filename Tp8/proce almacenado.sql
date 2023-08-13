use BDSucursales
go

create procedure SP_Agregar
(
@NombreSucursal varchar (100),
@DescripcionSucursal varchar (100),
@Id_ProvinciaSucursal int,
@DireccionSucursal varchar (100)
)
as
insert into Sucursal(NombreSucursal,DescripcionSucursal,Id_ProvinciaSucursal,DireccionSucursal)
select @NombreSucursal,@DescripcionSucursal,@Id_ProvinciaSucursal,@DireccionSucursal
return 
go

create procedure SP_AEliminar
(
@ID int
)
as
delete Sucursal where @ID=Id_Sucursal
return 
go