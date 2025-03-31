# Принципи програмування в системі управління складом

У цьому проекті реалізовано систему управління складом з дотриманням принципів програмування. Нижче наведено опис кожного з принципів та приклади їх застосування в коді.

## SOLID принципи

### 1. Принцип єдиного обов'язку (Single Responsibility Principle)

Кожен клас має одну відповідальність і одну причину для змін.

**Приклади:**
- Клас `Warehouse` [WarehouseManagementSystem/Warehouse.cs:7-65](WarehouseManagementSystem/Warehouse.cs#L7-L65) відповідає лише за управління товарами на складі.
- Клас `Product` [WarehouseManagementSystem/Product.cs:8-41](WarehouseManagementSystem/Product.cs#L8-L41) відповідає лише за інформацію про продукт.
- Клас `Reporting` [WarehouseManagementSystem/Reporting.cs:7-91](WarehouseManagementSystem/Reporting.cs#L7-L91) відповідає лише за генерацію звітів.

### 2. Принцип відкритості/закритості (Open/Closed Principle)

Програмні сутності (класи, модулі, функції) мають бути відкриті для розширення, але закриті для модифікації.

**Приклади:**
- Клас `Money` [WarehouseManagementSystem/Money.cs:6-54](WarehouseManagementSystem/Money.cs#L6-L54) розширюється класом `UahMoney` [WarehouseManagementSystem/Money.cs:55-63](WarehouseManagementSystem/Money.cs#L55-L63), який додає специфічну функціональність без зміни базового класу.
- Метод `Display()` [WarehouseManagementSystem/Money.cs:42-45](WarehouseManagementSystem/Money.cs#L42-L45) оголошений як `virtual` у базовому класі та перевизначений у похідному класі.

### 3. Принцип підстановки Лісков (Liskov Substitution Principle)

Об'єкти в програмі можуть бути замінені їх підтипами без порушення коректності роботи програми.

**Приклади:**
- Клас `UahMoney` [WarehouseManagementSystem/Money.cs:55-63](WarehouseManagementSystem/Money.cs#L55-L63) може бути використаний скрізь, де очікується `Money`, без порушення функціональності програми, що демонструється у методі `GenerateInvoice` [WarehouseManagementSystem/Reporting.cs:23-77](WarehouseManagementSystem/Reporting.cs#L23-L77).

### 4. Принцип розділення інтерфейсу (Interface Segregation Principle)

Клієнти не повинні залежати від інтерфейсів, які вони не використовують.

**Приклади:**
- Класи мають мінімальні публічні інтерфейси. Наприклад, клас `WarehouseItem` [WarehouseManagementSystem/WarehouseItem.cs:3-47](WarehouseManagementSystem/WarehouseItem.cs#L3-L47) надає лише необхідні операції: `AddQuantity` та `RemoveQuantity`.

### 5. Принцип інверсії залежностей (Dependency Inversion Principle)

Високорівневі модулі не повинні залежати від низькорівневих модулів. Обидва повинні залежати від абстракцій.

**Приклади:**
- Клас `Reporting` [WarehouseManagementSystem/Reporting.cs:7-91](WarehouseManagementSystem/Reporting.cs#L7-L91) працює з абстракцією `Money` [WarehouseManagementSystem/Money.cs:6-54](WarehouseManagementSystem/Money.cs#L6-L54), а не з конкретною реалізацією, що дозволяє використовувати різні валюти.

## Інші принципи програмування

### 6. DRY (Don't Repeat Yourself)

Принцип уникнення дублювання коду.

**Приклади:**
- Метод `GenerateInvoice` [WarehouseManagementSystem/Reporting.cs:23-77](WarehouseManagementSystem/Reporting.cs#L23-L77) є спільним для формування різних типів накладних, що уникає дублювання коду.
- Метод `NormalizeAmount` [WarehouseManagementSystem/Money.cs:21-29](WarehouseManagementSystem/Money.cs#L21-L29) використовується в різних частинах класу `Money` для забезпечення коректного представлення грошової суми.

### 7. KISS (Keep It Simple, Stupid)

Принцип максимальної простоти коду.

**Приклади:**
- Клас `ProductCategory` [WarehouseManagementSystem/ProductCategory.cs:3-9](WarehouseManagementSystem/ProductCategory.cs#L3-L9) реалізований як простий перелік, що спрощує категоризацію продуктів.
- Клас `InvoiceItem` [WarehouseManagementSystem/InvoiceItem.cs:3-15](WarehouseManagementSystem/InvoiceItem.cs#L3-L15) має просту структуру, яка містить лише необхідні дані.

### 8. YAGNI (You Aren't Gonna Need It)

Не додавати функціональність, поки вона реально не потрібна.

**Приклади:**
- Класи містять лише необхідну функціональність. Наприклад, клас `Product` [WarehouseManagementSystem/Product.cs:8-41](WarehouseManagementSystem/Product.cs#L8-L41) надає лише необхідні методи без надлишкової функціональності.

### 9. Composition Over Inheritance

Перевага композиції над успадкуванням.

**Приклади:**
- Клас `WarehouseItem` [WarehouseManagementSystem/WarehouseItem.cs:3-47](WarehouseManagementSystem/WarehouseItem.cs#L3-L47) використовує композицію для включення `Product` як властивості, а не успадковує його.
- Клас `InvoiceItem` [WarehouseManagementSystem/InvoiceItem.cs:3-15](WarehouseManagementSystem/InvoiceItem.cs#L3-L15) включає `Product` як властивість, що дозволяє повторно використовувати функціональність.

### 10. Program to Interfaces not Implementations

Програмування на рівні інтерфейсів, а не конкретних реалізацій.

**Приклади:**
- Метод `GenerateInvoice` [WarehouseManagementSystem/Reporting.cs:23-77](WarehouseManagementSystem/Reporting.cs#L23-L77) працює з абстракцією `Money` [WarehouseManagementSystem/Money.cs:6-54](WarehouseManagementSystem/Money.cs#L6-L54), що дозволяє підтримувати різні валюти.

### 11. Fail Fast

Виявлення помилок на найбільш ранньому етапі.

**Приклади:**
- У конструкторі `Product` [WarehouseManagementSystem/Product.cs:15-21](WarehouseManagementSystem/Product.cs#L15-L21) перевіряються передані значення та генеруються винятки при некоректних параметрах.
- Метод `AddQuantity` [WarehouseManagementSystem/WarehouseItem.cs:16-25](WarehouseManagementSystem/WarehouseItem.cs#L16-L25) перевіряє передане значення кількості та генерує виняток при негативному значенні. 