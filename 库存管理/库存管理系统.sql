create database 超市库存
create table 账户
(
账号 varchar(20) not null,
密码 varchar(20) not null
)

CREATE TABLE employee (
    员工编号 VARCHAR(16) PRIMARY KEY,
    姓名 VARCHAR(20),
    性别 VARCHAR(3),
    年龄 VARCHAR(3),
    工龄 VARCHAR(3),
    手机号码 VARCHAR(20),
    家庭住址 VARCHAR(30)

CREATE TABLE 商品 (
    商品编号 INT PRIMARY KEY,
    员工编号 varchar(16),
    品牌 NVARCHAR(100),
    商品名称 NVARCHAR(100),
    价格 DECIMAL(18, 2),
    入库数量 INT,
    FOREIGN KEY (员工编号) REFERENCES employee(员工编号)
);


);