# Ejercicio: Gestión de Stock de un Almacén en C# con WinForms

## Objetivo

El objetivo de este ejercicio es desarrollar una aplicación de escritorio utilizando **C#** y **Windows Forms (WinForms)** que permita gestionar el inventario de un almacén. La aplicación debe permitir agregar, editar y mostrar los productos disponibles en el almacén.

## Requisitos

1. **Formulario Principal**: Un formulario que muestre todos los productos del almacén en un `DataGridView` y tenga botones para agregar y editar productos.
2. **Formulario de Creación/Edición de Producto**: Un formulario adicional para crear un nuevo producto o editar uno existente.
3. **Clase Producto**: Cada producto debe tener un nombre, cantidad disponible y precio unitario.

## Requerimientos del Proyecto:

### 1. Clase Producto

Crea una clase llamada `Producto` con las siguientes propiedades:

- `Nombre` (tipo `string`)
- `Cantidad` (tipo `int`)
- `Precio` (tipo `decimal`)

La clase debe tener un constructor que reciba los tres parámetros: nombre, cantidad y precio.

### 2. Formulario Principal (`FormPrincipal`)

Crea un formulario que contendrá:

- Un `DataGridView` para mostrar el inventario de productos.
- Botones para agregar y editar productos.

El `DataGridView` debe mostrar tres columnas: `Nombre`, `Cantidad` y `Precio`.

Al iniciar la aplicación, se debe cargar una lista de productos predeterminada o vacía en el `DataGridView`.

Al hacer clic en el botón "Agregar Producto", debe abrirse un formulario para ingresar un nuevo producto.

Al seleccionar un producto de la lista y hacer clic en el botón "Editar Producto", debe abrirse el formulario de creación/edición con los datos del producto seleccionado, donde se podrá modificar su nombre, cantidad y precio.

### 3. Formulario de Creación/Edición de Producto (`FormProducto`)

Crea un formulario con tres campos de texto:

- `Nombre` (para ingresar el nombre del producto)
- `Cantidad` (para ingresar la cantidad de producto disponible)
- `Precio` (para ingresar el precio unitario del producto)

Este formulario tendrá un botón "Guardar" que:

- Si es un nuevo producto, creará un nuevo objeto `Producto` con los valores ingresados.
- Si es una edición, actualizará el producto existente con los nuevos valores.

Al guardar los datos, el formulario debe cerrarse y regresar al formulario principal, donde el producto debe reflejarse en el `DataGridView`.

### 4. Interacción entre los formularios

El formulario `FormPrincipal` debe poder recibir los datos de un nuevo producto o los datos modificados desde el formulario `FormProducto`.

El `DataGridView` debe actualizarse automáticamente después de agregar o editar un producto.

## Pasos a seguir:

### Paso 1: Crear el Proyecto

Crea un nuevo proyecto de tipo "Windows Forms App (.NET Framework)" en Visual Studio y nómbralo como `GestionStockAlmacen`.

### Paso 2: Crear la Clase `Producto`

En el proyecto, agrega una nueva clase llamada `Producto` con las propiedades y el constructor indicado en el enunciado.

### Paso 3: Crear el Formulario Principal (`FormPrincipal`)

Diseña el formulario principal agregando un `DataGridView` para mostrar los productos y botones para agregar y editar productos.

Implementa el código para manejar la carga de los productos y la interacción con los botones.

### Paso 4: Crear el Formulario para Crear/Editar Productos (`FormProducto`)

Crea el formulario que permita ingresar o editar los datos de un producto.

Implementa el código para gestionar la creación de un nuevo producto o la edición de uno existente.

### Paso 5: Interacción entre los Formularios

Implementa la lógica de pasar datos entre el formulario principal y el formulario de creación/edición de productos.

Asegúrate de que, después de agregar o editar un producto, el `DataGridView` se actualice correctamente.

### Paso 6: Pruebas

Prueba la aplicación agregando, editando y mostrando productos.

Asegúrate de que los cambios se reflejen correctamente en el formulario principal.

### Paso 7: Opcionales (Mejoras)

- Puedes agregar más validaciones, como asegurarte de que los campos de texto no estén vacíos y que la cantidad y el precio sean números válidos.
- Si tienes tiempo, puedes agregar la funcionalidad para eliminar productos del inventario.
- Puedes almacenar los productos en una base de datos o archivo para persistencia (opcional, para mejorar el ejercicio).

## Puntos a evaluar:

1. **Estructura y diseño**: ¿Cómo está organizado el código? ¿Se siguen buenas prácticas de programación?
2. **Interactividad**: ¿Funcionan correctamente los formularios de creación/edición de productos?
3. **Manejo de errores y validaciones**: ¿El programa maneja correctamente los casos en los que los campos no se completan o los valores no son válidos?
4. **Interfaz de usuario**: ¿La interfaz es clara y fácil de usar? ¿Es fácil agregar y editar productos?
