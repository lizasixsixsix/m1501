# 15 serialization

## 01 basic serialization

Опираясь на содержимое файла _books.xml_ (см. в материалах),
опишите структуру классов `Catalog` и `Book`
(при этом используйте принятый в C# подход к именованию классов и свойств
в _PascalCase_).

Обратите при этом внимание на то, что в коде:
*   жанр должен быть в представлен в виде _enumeration_;
*   должна быть доступна возможность работать с датами
    как с полноценными _DateTime_-структурами.

Добейтесь сериализации и десериализации ваших классов для _books.xml_.
