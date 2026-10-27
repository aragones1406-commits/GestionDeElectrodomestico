# Sistema de Gestión de COMPTECH

Aplicación de escritorio desarrollada en C# con Windows Forms para administrar los procesos de [describe brevemente qué hace tu sistema, ej: una biblioteca: libros, socios, préstamos, devoluciones y multas].

Proyecto del Primer Parcial de la asignatura Programación Avanzada en C#, Tecnologías de información / Universidad Técnica de Machala (UTMACH).

## Integrantes

| Nombre | Usuario de GitHub | Rol / Responsabilidad |
| :--- | :--- | :--- |
| Andres Rivera | aragones1406-commmits | Configuración del repositorio, pipeline CI y pruebas unitarias |
| Quezada Brithany | Thany30 | README, especificaciones y flujo de trabajo |

---

## Descripción del sistema

El sistema está diseñado para facilitar la gestión diaria del local de electrodomésticos, permitiendo al personal realizar las siguientes funciones:

*   **Gestión de Clientes:** Registrar, editar y consultar la información de los clientes (cédula, nombres, apellidos, dirección, teléfono).
*   **Gestión de Productos (Inventario):** Administrar el catálogo de electrodomésticos (código, nombre, marca, precio, stock disponible).
*   **Generación de Ventas:** Registrar las ventas realizadas, calculando automáticamente subtotales, IVA y total a pagar, descontando el stock de los productos vendidos.
*   **Consultas y Reportes:** Buscar información de ventas por fecha o cliente, y consultar el estado actual del inventario.
*   **Validación de Datos:** Control estricto en la validación de cédulas ecuatorianas y campos numéricos para evitar errores en el registro.

---

## Tecnologías utilizadas

*   **Lenguaje:** C#
*   **Framework:** .NET (Windows Forms)
*   **Control de versiones:** Git y GitHub
*   **Integración Continua (CI):** GitHub Actions

---

## Flujo de trabajo (Git)

Para mantener el orden en el proyecto, seguimos este flujo:

1.  **Issues:** Cada tarea o error se registra en la pestaña *Issues*.
2.  **Ramas (Branches):** Se crea una rama por cada tarea (ej. `feature/modulo-clientes`).
3.  **Pull Requests:** Al terminar, se abre un PR para revisar los cambios antes de fusionarlos.
4.  **CI:** GitHub Actions compila el proyecto automáticamente en cada PR.
