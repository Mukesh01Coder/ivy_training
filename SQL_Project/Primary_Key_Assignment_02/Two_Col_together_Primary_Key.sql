create table cricket_player (
		  country_code int,
		  country_name varchar(20),
		  player_name varchar(20),
		  primary key (country_name, player_name)
   );
insert into cricket_player values(1221,'India','Sacchin')
insert into cricket_player values(1225,'Sri Lanka','Afridi')
insert into cricket_player values(1228,'Bangladesh','Soumya Sarkar')
insert into cricket_player values(1229,'England','Jos Buttler')
insert into cricket_player values(1221,'India','Yuvraj')
insert into cricket_player values(1225,'Sri Lanks','Yuvraj')

insert into cricket_player values (1221,'India','Dhoni')
insert into cricket_player values (1221,'India','Dhoni')
insert into cricket_player values (1221,'India',' ')
insert into cricket_player values (1221,' ','Virat Kohli')

insert into cricket_player values (1221, null ,'Virat Kohli')
insert into cricket_player values (1221,'India ',null)

select * from cricket_player


