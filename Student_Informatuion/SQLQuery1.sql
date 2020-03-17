use Student_Info;
select * from student;


create table StudentInformation(StudentNo int identity(1,1) primary key,StudentName Varchar(100),Course Varchar(100),DOJ datetime);
select * from StudentInformation;

create database stud;
use stud;
create table StudentInformation(StudentNo int identity(1,1) primary key,StudentName Varchar(100),Course Varchar(100),DOJ datetime);
select * from StudentInformation;