# Catálogo de Productos – Prueba Técnica ASP.NET Core

Este proyecto corresponde a una **prueba técnica** desarrollada con **ASP.NET Core MVC**, **Entity Framework Core**, **ASP.NET Core Identity** y **SQL Server**.  
El objetivo es implementar un **catálogo de productos con autenticación de usuarios**, aplicando buenas prácticas de desarrollo y arquitectura MVC.

---

## Objetivo de la prueba

- Implementar autenticación y autorización de usuarios
- Diseñar y modelar una base de datos relacional
- Gestionar productos y categorías
- Proteger el acceso al catálogo mediante login
- Utilizar herramientas estándar del ecosistema ASP.NET Core

---

## Tecnologías utilizadas

- **ASP.NET Core MVC (.NET 8)**
- **Entity Framework Core**
- **ASP.NET Core Identity**
- **SQL Server**
- **Bootstrap**
- **Razor Views**
- **Git**

---

## Autenticación

Al ejecutar el proyecto se valida correctamente:

- Registro de usuarios
- Inicio de sesión
- Cierre de sesión

El acceso al catálogo de productos está protegido y requiere autenticación.

---

## Diseño de la base de datos

Además de las tablas generadas por **Identity**, se crearon dos entidades principales:

---

### Category

| Campo | Tipo |
|------|------|
| Id | int |
| Name | string |
| Description | string |
| CreatedAt | DateTime |

---

### Product

| Campo | Tipo |
|------|------|
| Id | int |
| Name | string |
| Quantity | int |
| Price | decimal |
| ImagePath | string |
| CreatedAt | DateTime |
| CategoryId | int (FK) |

---

### Relación entre entidades

- Una **categoría** puede tener **muchos productos**
- Un **producto** pertenece a **una categoría**

(Relación **uno a muchos**)

---

## Configuración de la base de datos

La cadena de conexión se define en `appsettings.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=DESKTOP-801STID;Database=CatalogoProductos;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true"
}
```

## Migración y base de datos
```bash
Add-Migration Initial
Update-Database
```

## Resetear la base de datos (Solo en desarrollo)
```bash
Update-Database 0
```

## Manejo de imágenes
```bash
wwwroot/images/productos/
```

## Repositorio en GitHub
```bash
https://github.com/Godie84/CatalogoVirtual.git
```