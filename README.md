## 📘 Лабораторки по програмированию 📘

Здесь я размещаю все текущие лабораторные работы.  
Задания выкладываются здесь:

- [<img src="https://www.gstatic.com/images/branding/product/1x/drive_2020q4_48dp.png" height="16" style="vertical-align:middle"> Лабораторные работы по C++](https://drive.google.com/drive/folders/1_F-8I2-DN5b8p6-kbm6cEQAcjFATuoMa)
- [<img src="https://www.gstatic.com/images/branding/product/1x/drive_2020q4_48dp.png" height="16" style="vertical-align:middle"> Лабораторные работы по C#](https://drive.google.com/drive/folders/1rwWDtmsvWua6DeTQ_o7r-3eUKcDsQHDD)

## Cтруктура проекта на данный момент:
<details>
<summary>ДИАГРАММА</summary>

```mermaid
graph TD;
  ALL_LABS-->LABS_C_Sharp["C#"];
    LABS_C_Sharp-->C1["C# 1"];
    LABS_C_Sharp-->C2["C# 2"];
  ALL_LABS-->LABS_C_Plus_Plus["C++"];
    LABS_C_Plus_Plus-->CPP1["C++ 1"];
    LABS_C_Plus_Plus-->CPP2["C++ 2"];
    LABS_C_Plus_Plus-->CPP3["C++ 3"];
    LABS_C_Plus_Plus-->CPP4_1["C++ 4_1"];
    LABS_C_Plus_Plus-->CPP4_2["C++ 4_2"];
    LABS_C_Plus_Plus-->CPP5_1["C++ 5_1"];
    LABS_C_Plus_Plus-->CPP5_2["C++ 5_2"];
```
</details>



## 🚀 Языки программирования

### C++ ПРИМЕР
```cpp
#include <iostream>
int main() {
    std::cout << "Hello world!\n";
    return 0;
}
```
- **Тип**: Компилируемый, статически типизированный  
- **Парадигма**: Мультипарадигменный (ООП, процедурный, generic)  
- **Сильные стороны**:  
  - Высокая производительность  
  - Прямой доступ к памяти  
  - Богатая стандартная библиотека (STL)  
- **Использование**: Игры, драйверы, высоконагруженные системы  

### C# ПРИМЕР
```csharp
using System;
class Program {
    static void Main() {
        Console.WriteLine("Hello World!");
    }
}
```
- **Тип**: Компилируемый в байт-код, управляемый  
- **Парадигма**: Объектно-ориентированный  
- **Сильные стороны**:  
  - Простота изучения  
  - Богатая экосистема (.NET)  
  - Автоматическое управление памятью (GC)  
- **Использование**: Веб-приложения, десктоп (WPF), игры (Unity)  
      
| Характеристика   | C++ | C# |
|----------------------|-------------------|-------------------|
| Управление памятью   | Вручную           | Автоматическое (GC) |
| Производительность   | ⭐⭐⭐⭐⭐          | ⭐⭐⭐⭐           |
| Скорость разработки  | ⭐⭐⭐             | ⭐⭐⭐⭐⭐          |
| Кроссплатформенность | Да                | Да (.NET Core)    |


