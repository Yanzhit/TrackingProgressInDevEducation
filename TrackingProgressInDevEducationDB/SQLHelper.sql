/*
-- Создание таблица с именем "Product"
Create table Product 
(
/*  Создание столбца с именем "id" типа int,
    identity - это параметр уникальности   */
	[id] int identity,

/*  Создание столбца с именем "Name" параметризированного
	типа "nvarchar" "(20)" - это параметр,
	"not null" поле не может быть null.
	"check" - это параметр условия в примере "(Cost > 0)" 
	"<>" - не равно, недавно добавили  второй вариант записи"!="
	"unique" - это параметр уникальности имен*/
	[Name] nvarchar(20) not null unique,

	/*  Создание столбца с именем "Cost" параметризированного
	типа "decimal" параметр не указан, но возможно указывать 
	"decimal(10, 2)" - где 10 - это всего символов,
	"," - тоже считается, 2 - это количество символов после ","
	"check" - это параметр условия в примере "(Cost > 0)" 
	"<>" - не равно, недавно добавили  второй вариант записи"!=" */
	[Cost] decimal check(Cost > 0),

	/*  Создание столбца с именем "Amount" типа int,
	"default" - значение по умолчанию "0" - само значение	
	*/
	[Amount] int default 0
)

/* Добавление в таблицу строк
"insert [Product]" - указывает конкретную таблицу
"values('WWW', 90, 8)" - добавляем значения
без явного указания полей */
insert [Product] 
values('WWW', 90, 8)


/* Добавление в таблицу строк с явным указанием полей
"([Name], [Cost], [Amount])" - явно указанные поля */
insert [Product] ([Name], [Cost], [Amount])
values('RFw', 550, 8)

/* Добавление в таблицу строк с явным выборочным 
указанием полей "([Name], [Cost])" - тут опускаем 
поле "[Amount]" - так как оно устанавливается по умолчанию */
insert [Product] ([Name], [Cost])
values('QQQ', 30)

/* Добавление в таблицу более
одного объекта  производится при помощи "," */
insert [Product] (Name, Cost)
values('QwQ', 50),
('EEE', 9)

-- Выбор таблицы с названием "[Product]", и показ всех полей
select * from [Product]

/* Выбор таблицы "[Product]", и показ полей "id" и "Name"
для выбора перечесления отображаемых полей "," */
select [id], [Name] from [Product]


select [P].[id], [P].[Name], [P].[Cost] * [P].[Amount] as [Summ] -- "Summ" это название столбика
from [Product] as [P] -- "P" 

select * from [Product] as [P]
where ([P].[Amount] > 0)

select [P].[id], [P].[Name], [P].[Cost] * [P].[Amount] as [Summ]
from [Product] as [P]
where ([P].[Amount] > 0 and [P].[Cost] * [P].[Amount] is not null) --Вывод если не равно null и > 0

select [P].[id], [P].[Name], sum([P].[Cost] * [P].[Amount]) as [Summ]
from [Product] as [P]
where ([P].[Amount] > 0 and [P].[Cost] * [P].[Amount] is not null)

--"Order" - это сортировка "Summ", "Name" это критерии сортировки через запятую
order by [Summ], [Name] 

-- Обновление значений
update [Product]
set [Amount] = [Amount] + 10
where [id] = 7

update [Product]
set [Cost] = 10
where [Cost] is Null

-- Удаление значений
delete [Product]
where [Cost] = 10
*/

