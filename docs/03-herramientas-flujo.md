Fase 3: Herramientas Utilizadas y Flujo de Trabajo

## 1. Entorno de Desarrollo
*   **IDE:** Visual Studio 2022.
*   **Lenguaje:** C# (.NET 6 o superior).
*   **Control de Versiones:** Git y GitHub.
*   **Base de Datos:** [Escribe la BD que usaste].

## 2. Aplicación de la Metodología (GitHub Flow)
Para el desarrollo guiado por especificaciones, aplicamos el siguiente flujo en GitHub:

1.  **Gestión de Tareas (Issues):** Cada requerimiento (ej. "Validar cédula") se convirtió en un *Issue* en GitHub.
2.  **Ramificación (Branches):** Por cada Issue, se creó una rama específica (ej. `feature/modulo-clientes`).
3.  **Desarrollo (Code):** Se programó la funcionalidad en Visual Studio y se subieron los cambios (Commit y Push).
4.  **Revisión (Pull Requests):** Se creó un Pull Request para comparar los cambios antes de unirlos a la rama principal (`master`).
5.  **Integración Continua (CI/CD):** Se implementó **GitHub Actions** (archivo `ci.yml`) para que cada vez que se sube código, el sistema compile automáticamente y verifique que no haya errores (Check verde).
