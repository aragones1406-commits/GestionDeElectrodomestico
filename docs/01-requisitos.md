# Fase 1: Análisis de Requisitos

## 1. Requisitos Funcionales (¿Qué debe hacer el sistema?)
*   **RF-01 (Clientes):** El sistema debe permitir registrar, editar y consultar clientes (cédula, nombres, apellidos, dirección, teléfono).
*   **RF-02 (Validación):** El sistema debe validar que la cédula ingresada cumpla con el algoritmo de la cédula ecuatoriana.
*   **RF-03 (Productos):** El sistema debe permitir administrar el catálogo de electrodomésticos (código, marca, precio, stock).
*   **RF-04 (Ventas):** El sistema debe permitir generar una venta, seleccionando un cliente y varios productos.
*   **RF-05 (Cálculos):** El sistema debe calcular automáticamente el subtotal, el IVA (15%) y el total a pagar de la venta.
*   **RF-06 (Inventario):** Al concretar una venta, el sistema debe descontar automáticamente el stock de los productos vendidos.
*   **RF-07 (Consultas):** El sistema debe permitir buscar ventas por fecha o por cliente.

## 2. Requisitos No Funcionales (¿Cómo debe comportarse?)
*   **RNF-01 (Tecnología):** Debe ser una aplicación de escritorio desarrollada en C# con Windows Forms.
*   **RNF-02 (Interfaz):** La interfaz debe ser intuitiva y fácil de usar para el personal del local.
*   **RNF-03 (Persistencia):** La información debe guardarse en una base de datos (SQL Server o SQLite) para no perder datos al cerrar el programa.
*   **RNF-04 (Rendimiento):** Las consultas de ventas deben tardar menos de 2 segundos.
