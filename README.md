

# TIENDA DE ELECTRONICA
 Proyecto creado para evaluación de LaboratorioII y programaciónII.
 Se nos pide generar una aplicación de escritorio para una tienda de electrónica que gestione un inventario de productos y un sistema de ventas.

 ## Autor
  * [Adrian Villagomez](https://github.com/adrianvillagomez)
## Electronic life
* 🚀**Menu Login**

Es el punto de entra de nuestra Aplicación contara con los siguientes botones :

![Imagen](/ImagenesMd/Autompletar.png) 

**Elegir Rol y autocompletar** : Se pide elegir el rol de vendedor o administrador y se autocompletara automáticamente para un acceso rápido.Si elegimos vendedor nos llevara a administrar ventas directamente y si elegimos administrador nos llevara a un menu principal con diferentes opciones, 

![Imagen](/ImagenesMd/Login2.png)


### Administrador


* 🚀**Menu Principal**

Menu principal donde solo ingresara el usuario logeado como administrador.

📌**Botón Administrar Inventario** : Nos llevara al menu para administrar nuestros productos

📌**Botón Administrar Venta**  : Nos llevara al menu Administrar Ventas donde venderemos nuestro productos.

![Imagen](/ImagenesMd/MenuPrincipal.png)

* 🚀**Administrar Inventario**

En este formulario podremos ver todos nuestros productos existentes y agregar mas cantidades al stock o ingresar mas productos.

📌**Sección Detalle Producto** : Esta sección nos permitirá Agregar productos a nuestro Inventario.

📌**Sección Lista de Producto** : En esta sección se mostrar todos los productos con sus detalles y su stock.


![Imagen](/ImagenesMd/Inventario.png)


![Imagen](/ImagenesMd/AgregarProducto.png) : Agregara un producto a nuestro inventario, Si el producto a agregar ya se encuentra en nuestro inventario este sumara la cantidad a ingresar al stock del producto en nuestro inventario.

![Imagen](/ImagenesMd/ADMVentas.png) : Nos llevara al menu de ventas.

📌**Buscar por Tag** : Filtrara nuestra lista por el criterio de búsqueda.

![Imagen](/ImagenesMd/Buscador.png) : Al presionarlo buscara el producto filtrador por nuestro buscador.

![Imagen](/ImagenesMd/Refrescar.png) : Mostrar nuevamente todos nuestro Productos.

📌**Cerrar sesión** : Cerrara nuestra aplicación y volveremos al login

## Vendedor

* 🚀**Administrar Inventario**

En esta sección llevaremos a cabo nuestras ventas agregando tantos productos como queramos a nuestro carrito de compras y generando una factura para finalizar la venta o cancelar la venta.También tendremos un registro de todas nuestra facturas realizadas

![Imagen](/ImagenesMd/VentasAdm.png)

📌**Buscar Producto** : Buscaremos un producto para vender y agregaremos con doble click a la sección detalle.

📌**Detalle** : Nos mostrar el producto seleccionado previamente y ver si queremos agregarlo al carrito.

📌**Carrito de Compras** : Nos mostrara una lista de todos los productos a comprar.
<br>
<br>
![Imagen](/ImagenesMd/agregaralcarrito.png) : Agregaremos el producto de nuestra sección detalle a nuestro carrito de compras.
<br>
<br>
![Imagen](/ImagenesMd/Limpiar.png) : Limpiara todos los campos para realizar una nueva venta.
<br>
<br>
![Imagen](/ImagenesMd/cliente.png) : Campos obligatorios para obtener los datos del cliente.

![Imagen](/ImagenesMd/generarFactura.png) 

 * Nos mostrara los totales a pagar y el botón generar factura nos mostrar como queda la factura.Los métodos de pago con crédito tendrán un recargo de 10%.


 ![Imagen](/ImagenesMd/factura.png) 
 * Factura generada por nuestro botón de generar factura.

 ![Historial facturación](/ImagenesMd/Historial.png)

 📌**Historial Facturación** : Nos mostrar el historial de todas nuestras facturas.
 Si hacemos doble click el la fila del dragridview nos mostrara el detalle de nuestro producto.

![Imagen](/ImagenesMd/Detalle.png) 

## Lecciones Aprendidas

+ Clases y métodos estáticos
+ OOP
+ Sobrecarga
+ WindowsForms
+ Colecciones
+ Enumerados
+ Encapsulamiento
+ Herencia
+ Polimorfismo


