# SI730PC2U<codigo-estudiante>.API

## LogisticsPro - Warehouse Management System (WMS)

Este proyecto implementa un API RESTful para la plataforma LogisticsPro, un sistema de gestión de almacenes (WMS) diseñado para realizar operaciones de inventario y categorización de productos.

## Descripción del Proyecto

El API proporciona funcionalidades para la administración de productos y categorías en un almacén, integrando un sistema de auditoría y validación. LogisticsPro permite a los usuarios gestionar productos y categorías, cumpliendo con las reglas de negocio establecidas.

## Arquitectura del Proyecto

El proyecto sigue una arquitectura basada en Domain-Driven Design (DDD) y está estructurado en diferentes capas:

- **Application**: Contiene DTOs, Interfaces y Servicios.
- **Domain**: Define las Entidades, Enums y Excepciones del dominio.
- **Infrastructure**: Incluye la capa de persistencia y repositorios.
- **Shared**: Incluye entidades y objetos de valor comunes al dominio.
- **Interfaces**: Contiene los controladores para el API RESTful.

## Autor

Daiki Oscar Oshiro Yamashita
