

# TIENDA DE ELECTRONICA
 Proyecto creado para evaluaci贸n de LaboratorioII y programaci贸nII.
 Se nos pide generar una aplicaci贸n de escritorio para una tienda de electr贸nica que gestione un inventario de productos y un sistema de ventas.

 ## Autor
  * [Adrian Villagomez](https://github.com/adrianvillagomez)
## Electronic life
* 馃殌**Menu Login**

Es el punto de entra de nuestra Aplicaci贸n contara con los siguientes botones :

![Imagen](/ImagenesMd/Autompletar.png) 

**Elegir Rol y autocompletar** : Se pide elegir el rol de vendedor o administrador y se autocompletara autom谩ticamente para un acceso r谩pido.Si elegimos vendedor nos llevara a administrar ventas directamente y si elegimos administrador nos llevara a un menu principal con diferentes opciones, 

![Imagen](/ImagenesMd/Login2.png)


### Administrador


* 馃殌**Menu Principal**

Menu principal donde solo ingresara el usuario logeado como administrador.

馃搶**Bot贸n Administrar Inventario** : Nos llevara al menu para administrar nuestros productos

馃搶**Bot贸n Administrar Venta**  : Nos llevara al menu Administrar Ventas donde venderemos nuestro productos.

![Imagen](/ImagenesMd/MenuPrincipal.png)

* 馃殌**Administrar Inventario**

En este formulario podremos ver todos nuestros productos existentes y agregar mas cantidades al stock o ingresar mas productos.

馃搶**Secci贸n Detalle Producto** : Esta secci贸n nos permitir谩 Agregar productos a nuestro Inventario.

馃搶**Secci贸n Lista de Producto** : En esta secci贸n se mostrar todos los productos con sus detalles y su stock.


![Imagen](/ImagenesMd/Inventario.png)


![Imagen](/ImagenesMd/AgregarProducto.png) : Agregara un producto a nuestro inventario, Si el producto a agregar ya se encuentra en nuestro inventario este sumara la cantidad a ingresar al stock del producto en nuestro inventario.

![Imagen](/ImagenesMd/ADMVentas.png) : Nos llevara al menu de ventas.

馃搶**Buscar por Tag** : Filtrara nuestra lista por el criterio de b煤squeda.

![Imagen](/ImagenesMd/Buscador.png) : Al presionarlo buscara el producto filtrador por nuestro buscador.

![Imagen](/ImagenesMd/Refrescar.png) : Mostrar nuevamente todos nuestro Productos.

馃搶**Cerrar sesi贸n** : Cerrara nuestra aplicaci贸n y volveremos al login

## Vendedor

* 馃殌**Administrar Inventario**

En esta secci贸n llevaremos a cabo nuestras ventas agregando tantos productos como queramos a nuestro carrito de compras y generando una factura para finalizar la venta o cancelar la venta.Tambi茅n tendremos un registro de todas nuestra facturas realizadas

![Imagen](/ImagenesMd/VentasAdm.png)

馃搶**Buscar Producto** : Buscaremos un producto para vender y agregaremos con doble click a la secci贸n detalle.

馃搶**Detalle** : Nos mostrar el producto seleccionado previamente y ver si queremos agregarlo al carrito.

馃搶**Carrito de Compras** : Nos mostrara una lista de todos los productos a comprar.
<br>
<br>
![Imagen](/ImagenesMd/agregaralcarrito.png) : Agregaremos el producto de nuestra secci贸n detalle a nuestro carrito de compras.
<br>
<br>
![Imagen](/ImagenesMd/Limpiar.png) : Limpiara todos los campos para realizar una nueva venta.
<br>
<br>
![Imagen](/ImagenesMd/cliente.png) : Campos obligatorios para obtener los datos del cliente.

![Imagen](/ImagenesMd/generarFactura.png) 

 * Nos mostrara los totales a pagar y el bot贸n generar factura nos mostrar como queda la factura.Los m茅todos de pago con cr茅dito tendr谩n un recargo de 10%.


 ![Imagen](/ImagenesMd/factura.png) 
 * Factura generada por nuestro bot贸n de generar factura.

 ![Historial facturaci贸n](/ImagenesMd/Historial.png)

 馃搶**Historial Facturaci贸n** : Nos mostrar el historial de todas nuestras facturas.
 Si hacemos doble click el la fila del dragridview nos mostrara el detalle de nuestro producto.

![Imagen](/ImagenesMd/Detalle.png) 

## Lecciones Aprendidas

+ Clases y m茅todos est谩ticos
+ OOP
+ Sobrecarga
+ WindowsForms
+ Colecciones
+ Enumerados
+ Encapsulamiento
+ Herencia
+ Polimorfismo


