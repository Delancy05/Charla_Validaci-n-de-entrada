# Charla_Validaci-n-de-entrada 
# Propiedades del Control TextBox en C# (Windows Forms)

Este repositorio ilustra el uso de tres propiedades fundamentales del control `TextBox` en aplicaciones de escritorio con C# (Windows Forms). Estas propiedades son esenciales para la validación de entrada, la mejora de la usabilidad y la garantía de la integridad de los datos en la capa de presentación.

A continuación, se detalla el funcionamiento y un escenario de uso práctico para cada una de las propiedades analizadas.

---

## 1. PasswordChar

### Resumen de Funcionamiento
La propiedad `PasswordChar` permite enmascarar o sustituir visualmente los caracteres que el usuario introduce en el `TextBox` por un carácter específico (por ejemplo, un asterisco `*`). Su objetivo principal es la privacidad visual, evitando que personas cercanas puedan leer información sensible mientras se escribe. Cabe destacar que esta propiedad solo oculta el texto en la interfaz; no cifra ni protege la contraseña a nivel de base de datos o lógica de sistema.

### Escenario Práctico: Formulario de Inicio de Sesión
Se implementa en una pantalla de inicio de sesión que solicita "Usuario" y "Contraseña". 
Al configurar el campo de contraseña con `txtContraseña.PasswordChar = '*';`, cuando el usuario digita su clave (por ejemplo, "12345678"), el campo muestra "********". Esto evita que la credencial quede expuesta visualmente en la pantalla, mejorando la privacidad durante la autenticación.

<img width="742" height="481" alt="WhatsApp Image 2026-10-06 at 11 18 17 AM" src="https://github.com/user-attachments/assets/ba6d2e3c-7f0b-4abf-8c91-eb5204801253" />

---

## 2. MaxLength

### Resumen de Funcionamiento
La propiedad `MaxLength` establece un límite estricto en la cantidad máxima de caracteres que un usuario puede ingresar (o pegar) en un `TextBox`. Por defecto, este límite es de 32,767 caracteres. Al configurar un valor específico, el control bloquea automáticamente cualquier intento de escribir más allá de ese límite, actuando como la primera línea de defensa para evitar desbordamientos de datos o errores al interactuar con las restricciones de una base de datos.

### Escenario Práctico: Registro de Estudiantes
Se utiliza en un formulario para registrar datos de estudiantes (Cédula y Nombre). 
En este escenario, la base de datos requiere que la cédula tenga un máximo de 10 caracteres y el nombre 30 caracteres. Al configurar `MaxLength = 10` para la cédula y `MaxLength = 30` para el nombre, el sistema impide físicamente que el usuario ingrese más dígitos de los permitidos. Esto evita fallos al guardar la información en la base de datos y mantiene la lista dinámica (`DataGridView`) libre de errores de longitud.

<img width="796" height="486" alt="WhatsApp Image 2026-10-06 at 11 19 59 AM" src="https://github.com/user-attachments/assets/ac7f689f-7529-40f1-a4e1-2f5f39613216" />

---

## 3. ReadOnly

### Resumen de Funcionamiento
La propiedad `ReadOnly` (booleana: `true` / `false`) permite bloquear la edición manual del `TextBox` a través del teclado. A diferencia de deshabilitar completamente el control (`Enabled = false`), `ReadOnly` permite que el usuario pueda hacer clic en el campo, seleccionar el texto y copiarlo al portapapeles. Además, el contenido del `TextBox` sigue pudiendo ser modificado internamente a través del código fuente de la aplicación.

### Escenario Práctico: Formulario de Facturación
Se aplica en un módulo de facturación donde existen campos cuyo valor es el resultado de un cálculo automático (por ejemplo, el "Total a Pagar"). 
Al establecer `txtTotalPagar.ReadOnly = true`, el sistema calcula el total (Subtotal + ITBMS) y lo muestra en la interfaz. El usuario no puede alterar este monto maliciosa o accidentalmente tecleando sobre él, pero sí puede seleccionarlo y presionar `Ctrl + C` para copiar el valor si lo necesita para otro propósito. Esto garantiza la integridad de las operaciones matemáticas del sistema.

<img width="740" height="487" alt="WhatsApp Image 2026-10-06 at 11 18 40 AM" src="https://github.com/user-attachments/assets/a99144f8-8583-4eec-b370-abd9fd248896" />
