create proc insert_cat

@name nchar(10)

as
insert into Departments (Dep_Name) values (@name)



