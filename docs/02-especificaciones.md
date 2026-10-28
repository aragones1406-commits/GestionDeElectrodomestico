# Fase 2: Especificaciones Técnicas (SDD)

## 1. Arquitectura del Sistema
Se utilizará el patrón de diseño **MVC (Modelo-Vista-Controlador)** o **Capas** para separar la lógica de negocio de la interfaz gráfica.
*   **Vistas (Forms):** `frmCLIENTES`, `frmPRODUCTOS`, `frmVENTAS`.
*   **Controladores/Lógica:** Clases para validar cédulas, calcular IVA y gestionar transacciones.
*   **Entidades/Modelos:** Clases `Cliente`, `Producto`, `Venta`.

## 2. Especificación del Módulo de Ventas (Ejemplo de especificación estricta)
*   **Entrada:** ID del cliente, lista de productos seleccionados, cantidades.
*   **Proceso:** 
    1. Verificar que el cliente exista.
    2. Verificar que haya stock suficiente para cada producto.
    3. Calcular: `Subtotal = Suma(Precio * Cantidad)`.
    4. Calcular: `Total = Subtotal + (Subtotal * 0.15)`.
    5. Guardar la venta en la Base de Datos.
    6. Restar la cantidad vendida del inventario.
*   **Salida:** Mensaje de éxito con el ID de la factura generada o mensaje de error si no hay stock.

## 3. Diccionario de Datos (Base de Datos)
*   **Tabla Clientes:** `id_cliente (PK)`, `cedula`, `nombres`, `direccion`.
*   **Tabla Productos:** `id_producto (PK)`, `nombre`, `precio`, `stock`.
*   **Tabla Ventas:** `id_venta (PK)`, `id_cliente (FK)`, `fecha`, `total`.
