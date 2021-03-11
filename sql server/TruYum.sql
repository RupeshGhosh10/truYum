create database truyum;
use truyum;

create table menu_items (
	item_id int primary key,
    item_name varchar(50),
    price decimal(5,2),
	active bit,
    date_of_launch date,
	category varchar(50),
    free_delivery bit
);

create table users (
	user_id int primary key,
    user_name varchar(60)
);

create table carts (
	item_id int,
    user_id int,
	primary key (item_id, user_id),
	foreign key (user_id) references users(user_id),
    foreign key (item_id) references menu_items(item_id)
);

-- 1.
insert into menu_items values
(1, 'Sandwich', 99, 1, '2017-03-15', 'Main Course', 1),
(2, 'Burger', 129, 1, '2017-12-23', 'Main Course', 0),
(3, 'Pizza', 149, 1, '2018-08-21', 'Main Course', 0),
(4, 'French Fries', 57, 0, '2017-07-15', 'Starters', 1),
(5, 'Chocolate Brownie', 32, 1, '2020-11-02', 'Dessert', 1);

select * from menu_items;

-- 2.
select * from menu_items where date_of_launch >= '2020-01-20' and active = 1;

-- 3.
select item_name from menu_items where item_id = 5;

update menu_items set price = 150 where item_id = 2;

-- 4.
insert into users values (1, 'Rupesh'), (2, 'Ram');

insert into carts values (2, 1), (3, 1);

-- 5.
select * from carts where user_id = 1;

select sum(b.price) from carts as a join menu_items as b
on a.item_id = b.item_id
where a.user_id = 1;

-- 6.
delete from carts where user_id = 1 and item_id = 3;