# 🏥 Backend - IPS Citas Médicas API (.NET 8)

Este es el backend de una aplicación para agendar citas médicas en una IPS, desarrollado en **.NET 8 WebAPI** con arquitectura limpia. Permite el manejo de pacientes, médicos y citas médicas.

---

## ✅ Requisitos

- [.NET SDK 8](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server Express 2022](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- Visual Studio 2022 o VS Code
- Postman o Insomnia (opcional, para pruebas)

---

## 🚀 Ejecución paso a paso

### 1. 🔃 Clona el repositorio

```bash
git clone <URL_DEL_REPOSITORIO>
cd IpsCitasMedicasBackend
```
---
### 2. 🔃 Configura la cadena de conexión: Edita el archivo appsettings.json con tu configuración local de SQL Server
```
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=IpsCitasDb;Trusted_Connection=True;TrustServerCertificate=True;"
}
```
---
###3. ⚙️ Ejecuta las migraciones y siembra los datos
Desde la terminal (en la raíz del proyecto):
```
dotnet ef database update
```
Esto creará la base de datos IpsCitasDb con las tablas y datos de ejemplo (médicos, pacientes y citas).

Si no tienes instalado EF Core CLI:
```
dotnet tool install --global dotnet-ef
```
---
4. ▶️ Ejecuta el servidor
```
dotnet run
```
```
https://localhost:5001
http://localhost:5000
http://localhost:5067
```
