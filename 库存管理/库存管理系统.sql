create database ���п��
create table �˻�
(
�˺� varchar(20) not null,
���� varchar(20) not null
)

CREATE TABLE employee (
    Ա����� VARCHAR(16) PRIMARY KEY,
    ���� VARCHAR(20),
    �Ա� VARCHAR(3),
    ���� VARCHAR(3),
    ���� VARCHAR(3),
    �ֻ����� VARCHAR(20),
    ��ͥסַ VARCHAR(30)

CREATE TABLE ��Ʒ (
    ��Ʒ��� INT PRIMARY KEY,
    Ա����� varchar(16),
    Ʒ�� NVARCHAR(100),
    ��Ʒ���� NVARCHAR(100),
    �۸� DECIMAL(18, 2),
    ������� INT,
    FOREIGN KEY (Ա�����) REFERENCES employee(Ա�����)
);


);