# Simulación Bases de Datos sobre Fórmula1
### Realizado para la asignatura de Bases de Datos
El proyecto ha sido desarrollado por completo en un repositorio privado y el resultado se ha subido a este repositorio.

## ⚙️ Configuración e Instalación

### 1. Base de Datos (MySQL)
El proyecto requiere una base de datos MySQL para funcionar.
1. Abre la carpeta del proyecto y localiza el archivo `FormulaUno.mwb` (o el `.sql`).
2. Ábrelo en **MySQL Workbench**.
3. Realiza la exportación/creación de la base de datos en tu servidor local (Forward Engineer).
4. Asegúrate de que la base de datos se llame tal cual se espera en el código: `formulauno`.

### 2. Configurar la Cadena de Conexión
Debes actualizar las credenciales para que coincidan con tu servidor local.
1. Abre el archivo **`AgenteBD.vb`** en Visual Studio.
2. Busca la variable que contiene la cadena de conexión (Connection String):
   `"server=localhost;database=formulauno;uid=tu_usuario;pwd=tu_contraseña"`
3. Cambia el `uid` (Usuario) y `pwd` (Contraseña) por los de tu instalación de MySQL.

### 3. ⚠️ Solución al error de compilación (Falta MySql.Data)
Si al intentar ejecutar recibes el error:
> *"No está definido el tipo 'MySql.Data.MySqlClient.MySqlConnection'"*

Esto ocurre porque falta la referencia al conector de MySQL. Para solucionarlo:
1. En Visual Studio, ve al menú **Proyecto** > **Administrar paquetes NuGet**.
2. Busca e instala el paquete **`MySql.Data`** (o `MySql.Data.EntityFramework` si lo usas).
3. Alternativamente, si ya está listado en el proyecto, haz clic derecho en la "Solución" (en el explorador de la derecha) y selecciona **"Restaurar paquetes NuGet"**.
