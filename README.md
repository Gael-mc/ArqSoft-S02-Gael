# 🎮 AHORCADO-TSW

Proyecto desarrollado para la materia de Arquitectura de Software.
Refactorización de una clase dios a diseño limpio siguiendo principios SOLID.

---

## 📋 Descripción

Aplicación de consola en C# que incluye dos juegos:
- **Ahorcado**: adivina la palabra antes de quedarte sin intentos
- **Víborita**: controla la serpiente y come comida sin chocar

El proyecto demuestra la evolución de una clase dios hacia un diseño limpio con responsabilidades separadas aplicando los principios SOLID.

---

## 🛠️ Tecnologías usadas

- C# / .NET 10.0
- Visual Studio 2022
- Git / GitHub

---

## 🏗️ Arquitectura del proyecto
AHORCADO-TSW/
├── IRepositorioPalabras.cs   → Interfaz (contrato de palabras)
├── PalabrasEnMemoria.cs      → Implementación con categorías
├── MotorAhorcado.cs          → Lógica del juego (sin Console)
├── ConsolaUI.cs              → Interfaz de usuario del ahorcado
├── IMotorJuego.cs            → Interfaz general de juegos
├── MotorViborita.cs          → Lógica de la víborita
├── ConsolaUIViborita.cs      → Interfaz de usuario de la víborita
├── Juego.cs                  → Clase dios original (referencia)
└── Program.cs                → Punto de entrada

---

## 🌿 Ramas

| Rama | Contenido |
|------|-----------|
| `master` | Ahorcado completo refactorizado |
| `feat/viborita` | Ahorcado + Víborita con menú selector |

---

## 📸 Capturas de pantalla

<img width="1918" height="1078" alt="Screenshot 2026-05-15 214310" src="https://github.com/user-attachments/assets/2a847260-013c-43da-aed6-94f5f9e10fbb" />

<img width="1918" height="1078" alt="Screenshot 2026-05-15 214342" src="https://github.com/user-attachments/assets/e9e64c75-6efa-47e3-95fa-4e1251a2c63b" />

<img width="1918" height="1078" alt="Screenshot 2026-05-15 214400" src="https://github.com/user-attachments/assets/73ecb49d-62e1-4d64-9fd2-ee79f39d6e7a" />

<img width="1918" height="1078" alt="Screenshot 2026-05-15 214446" src="https://github.com/user-attachments/assets/8ed2ba36-c01d-4ed7-8035-a3e77104c1f3" />




---

## 📌 Principios SOLID aplicados

| Principio | Aplicación |
|-----------|-----------|
| **SRP** | Cada clase tiene una sola responsabilidad |
| **OCP** | Nuevas fuentes de palabras sin modificar el motor |
| **DIP** | MotorAhorcado depende de IRepositorioPalabras, no de la implementación |

## 🤖 Uso de Inteligencia Artificial

Este proyecto fue desarrollado con apoyo de herramientas de Inteligencia Artificial,
específicamente Claude (Anthropic), utilizado como asistente de programación.

### ¿Para qué se usó?

- Corrección de errores de sintaxis en C#
- Orientación sobre estructura de archivos y namespaces
- Apoyo en la implementación de principios SOLID
- Resolución de errores de compilación en Visual Studio
- Guía para el uso de Git y GitHub (ramas, commits, push)

### ¿Cómo se usó?

El asistente fue consultado como apoyo técnico, similar a consultar
documentación o Stack Overflow. El desarrollo, la comprensión del código
y las decisiones de diseño fueron responsabilidad del estudiante.

### Herramienta utilizada

| Herramienta | Uso |
|-------------|-----|
| Claude (Anthropic) | Asistente de programación y depuración |

> El uso de IA fue transparente y con fines de aprendizaje,
> no para reemplazar el entendimiento del estudiante.

