# OrderApp - Aplicación de Procesamiento de Órdenes

[![Open in Codespaces](https://classroom.github.com/assets/launch-codespace-2972f46106e565e64193e422d61a12cf1da4916b45550586e14ef0a7c637dd04.svg)](https://classroom.github.com/open-in-codespaces?assignment_repo_id=21372752)
[![Build and Test](https://github.com/UPT-FAING-EPIS/examen-si889-2025-ii-u2-SebastianFuentesAvalos/actions/workflows/release_version.yml/badge.svg)](https://github.com/UPT-FAING-EPIS/examen-si889-2025-ii-u2-SebastianFuentesAvalos/actions/workflows/release_version.yml)
[![Documentation](https://github.com/UPT-FAING-EPIS/examen-si889-2025-ii-u2-SebastianFuentesAvalos/actions/workflows/publish_docs.yml/badge.svg)](https://github.com/UPT-FAING-EPIS/examen-si889-2025-ii-u2-SebastianFuentesAvalos/actions/workflows/publish_docs.yml)

## 📋 Descripción

Esta aplicación demuestra la implementación del **Patrón Facade** para simplificar el procesamiento de órdenes, coordinando múltiples servicios como inventario, pagos y envíos.

## 🏗️ Arquitectura - Patrón Facade

El patrón Facade se implementa para proporcionar una interfaz unificada para un conjunto de interfaces en un subsistema. Define una interfaz de nivel superior que hace que el subsistema sea más fácil de usar.

### Componentes Principales:

- **OrderFacade**: Facade que coordina todos los servicios
- **OrderProcessor**: Cliente refactorizado que utiliza el Facade
- **InventoryService**: Servicio de gestión de inventario
- **PaymentService**: Servicio de procesamiento de pagos
- **ShippingService**: Servicio de envíos

## 🚀 Características

- ✅ Implementación del patrón Facade
- ✅ Separación de responsabilidades
- ✅ Inyección de dependencias para testing
- ✅ Documentación XML completa
- ✅ Pruebas unitarias con XUnit
- ✅ Cobertura de código automatizada
- ✅ CI/CD con GitHub Actions
- ✅ Documentación automática con DocFX
- ✅ Diagramas de clase generados automáticamente

## 📊 Documentación

- [📖 Documentación API](https://upt-faing-epis.github.io/examen-si889-2025-ii-u2-SebastianFuentesAvalos/)
- [🎨 Diagrama de Clases](https://upt-faing-epis.github.io/examen-si889-2025-ii-u2-SebastianFuentesAvalos/disenio.html)
- [📈 Reporte de Cobertura](https://upt-faing-epis.github.io/examen-si889-2025-ii-u2-SebastianFuentesAvalos/coverage-report/)

## 🛠️ Tecnologías Utilizadas

- **.NET 8.0**: Framework principal
- **XUnit**: Framework de pruebas
- **Coverlet**: Herramienta de cobertura de código
- **DocFX**: Generador de documentación
- **dll2mmd**: Generador de diagramas de clase
- **GitHub Actions**: CI/CD
- **GitHub Pages**: Hosting de documentación

## 📦 Instalación

```bash
git clone https://github.com/UPT-FAING-EPIS/examen-si889-2025-ii-u2-SebastianFuentesAvalos.git
cd examen-si889-2025-ii-u2-SebastianFuentesAvalos/OrderApp
dotnet restore
dotnet build
```

## 🧪 Ejecutar Pruebas

```bash
# Ejecutar todas las pruebas
dotnet test

# Ejecutar con cobertura
dotnet test --collect:"XPlat Code Coverage"
```

## 💻 Uso

```csharp
// Uso directo del Facade
var orderFacade = new OrderFacade();
orderFacade.ProcessOrder("P001", "C123", 99.99m, "123 Main St");

// Uso a través del OrderProcessor refactorizado
var processor = new OrderProcessor();
processor.ProcessOrder("P001", "C123", 99.99m, "123 Main St");

// Con inyección de dependencias
var customFacade = new OrderFacade(inventoryService, paymentService, shippingService);
var processor = new OrderProcessor(customFacade);
```

## 🔄 CI/CD Pipeline

### Automatización de Documentación (`publish_docs.yml`)
- ✅ Compila el código
- ✅ Ejecuta pruebas con cobertura
- ✅ Genera diagrama de clases
- ✅ Crea documentación API
- ✅ Publica en GitHub Pages

### Automatización de Release (`release_version.yml`)
- ✅ Compila y ejecuta tests
- ✅ Genera reporte de cobertura completo
- ✅ Crea paquete NuGet
- ✅ Publica release en GitHub
- ✅ Actualiza documentación y cobertura

## 🏷️ Creación de Release

Para crear un nuevo release:

```bash
git tag -a v1.0.0 -m "Initial release with Facade pattern"
git push origin v1.0.0
```

## 👨‍💻 Autor

**Sebastian Nicolas Fuentes Avalos**
- Universidad Privada de Tacna - FAING EPIS
- Curso: Patrones de Diseño de Software

## 📄 Licencia

Este proyecto está bajo la Licencia MIT.
