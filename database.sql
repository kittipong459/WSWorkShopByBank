
AdaWSbyBank

ตารางข้อมูลสินค้า


CREATE TABLE TWsMPdt (
    FNPdtID int identity(1,1) primary key,
	FTPdtCod VARCHAR(10) NOT NULL,
    FTPdtName VARCHAR(50) NOT NULL,
    FTPdtDes VARCHAR(155),
    FCPdtPri float,
    FNPdtQty INT,
	FDPdtSMPT DATE,
    FNPdtTyp int
);


drop table TWsMPdt
select * from TWsMPdt

INSERT INTO TWsMPdt (FTPdtCod, FTPdtName, FTPdtDes, FCPdtPri, FNPdtQty, FDPdtSMPT,FNPdtTyp) VALUES
('PDT001', 'แป้งเด็ก', 'แป้งสำหรับเด็กอ่อน', 150.50, 100, '2024-01-10',2),
('PDT002', 'สบู่เหลว', 'สบู่เหลวสำหรับผู้ใหญ่', 75.25, 200, '2024-02-15',2),
('PDT003', 'แชมพูสระผม', 'แชมพูสำหรับผมธรรมดา', 120.00, 150, '2024-03-20',2),
('PDT004', 'ครีมกันแดด', 'ครีมกันแดด SPF 50', 250.00, 80, '2024-04-25',2),
('PDT005', 'โลชั่นบำรุงผิว', 'โลชั่นบำรุงผิวกาย', 200.75, 120, '2024-05-30',2);




CREATE TABLE TWsTSal (
    FNSalID int identity(1,1) primary key,
    FTSalCod VARCHAR(10),
    FTSalPdtCod VARCHAR(10),
    FNSalQty INT,
    FCSalPri float,
    FCSalAmt float,
    FTSalCstCod VARCHAR(10),
	FDSalDate date,
	FDSalSMPT DATE
);

drop table TWsTSal
select * from TWsTSal
INSERT INTO TWsTSal (FTSalCod,FTSalPdtCod, FNSalQty, FCSalPri, FCSalAmt, FTSalCstCod, FDSalDate, FDSalSMPT) VALUES
('sal1','PDT001', 2, 150.50, 301.00, 'CST001', '2024-01-20', '2024-01-21'),
('sal2','PDT002', 1, 75.25, 75.25, 'CST002', '2024-02-18', '2024-02-19'),
('sal3','PDT003', 3, 120.00, 360.00, 'CST003', '2024-03-05', '2024-03-06'),
('sal4','PDT004', 1, 250.00, 250.00, 'CST004', '2024-04-12', '2024-04-13'),
('sal5','PDT005', 5, 200.75, 1003.75, 'CST005', '2024-05-10', '2024-05-11');

CREATE TABLE TWsTSalHis (
    FNSalID int identity(1,1) primary key,
    FTSalCod VARCHAR(10),
    FTSalPdtCod VARCHAR(10),
    FNSalQty INT,
    FCSalPri float,
    FCSalAmt float,
    FTSalCstCod VARCHAR(10),
	FDSalDate date,
	FDSalSMPT DATE
);



CREATE TABLE TWsMCst (
    FNCstID int identity(1,1) primary key,
	FTCstCod VARCHAR(10) NOT NULL,
    FTCstName VARCHAR(255) NOT NULL,
    FTCstEml VARCHAR(255),
    FTCstPho VARCHAR(20),
    FTCstAdr TEXT,
    FDCstSMPT DATE,
);

drop table TWsMCst
select * from TWsMCst

INSERT INTO TWsMCst (FTCstCod, FTCstName, FTCstEml, FTCstPho, FTCstAdr, FDCstSMPT) VALUES
('CST001', 'สมชาย ใจดี', 'somchai@example.com', '0812345678', '123/45 ถนนสุขสวัสดิ์ แขวงบางแค เขตบางแค กรุงเทพฯ 10160', '2023-01-15'),
('CST002', 'นางสาวแอนนา สวยสยาม', 'anna@example.com', '0898765432', '456/78 ถนนประดิษฐ์มนูธรรม แขวงคลองจั่น เขตบางกะปิ กรุงเทพฯ 10240', '2022-05-22'),
('CST003', 'นายจอห์น สมิธ', 'john@example.com', '0823456789', '789/12 ถนนพหลโยธิน แขวงลาดยาว เขตจตุจักร กรุงเทพฯ 10900', '2024-02-01'),
('CST004', 'นางสาวมายด์ ฟ้าสวย', 'myde@example.com', '0859876543', '101/23 ถนนนวมินทร์ แขวงนวมินทร์ เขตบึงกุ่ม กรุงเทพฯ 10230', '2023-07-10'),
('CST005', 'นายสมศักดิ์ อัครเทพ', 'somsak@example.com', '0876543210', '202/34 ถนนลาดพร้าว แขวงคลองจั่น เขตบางกะปิ กรุงเทพฯ 10240', '2024-09-20');



create table TWsSSet(
FNstID int identity(1,1) primary key,
FTWstCode nvarchar(10),
FTWstName nvarchar(50),
FNWstType int
)

select * from TWsSSet

insert into TWsSSet(FTWstCode,FTWstName,FNWstType)
values('set1','ประเภทสินค้า 1:อาหาร 2:ของใช้',1)



SELECT 
    TS.FNSalID,
    C.FTCstName AS CustomerName,
    P.FTPdtName AS ProductName,
    TS.FNSalQty AS Quantity,
    TS.FCSalPri AS UnitPrice,
    TS.FCSalAmt AS TotalAmount,
    TS.FDSalDate AS SaleDate,
    TS.FDSalSMPT AS RecordDate,
	case when P.FNPdtTyp = 1 then 'ของกิน' else 'ของใช้' end  FNPdtTyp
FROM 
    TWsTSal TS
INNER JOIN 
    TWsMCst C ON TS.FTSalCstCod = C.FTCstCod
INNER JOIN 
    TWsMPdt P ON TS.FNSalPdtCod = P.FTPdtCod
LEFT JOIN 
    TWsSSet S ON S.FNWstType = P.FNPdtTyp
ORDER BY 
    TS.FNSalID;


/// view    

create view VIE_WsSal
as
SELECT 
    TS.FTSalCod,TS.FNSalQty,TS.FCSalPri,TS.FCSalAmt,TS.FDSalDate,
    TS.FDSalSMPT,c.FTCstCod,C.FTCstName,C.FTCstPho,C.FTCstEml,
	C.FTCstAdr,p.FTPdtCod,P.FTPdtName,P.FTPdtDes,P.FCPdtPri,p.FNPdtQty,
	case when P.FNPdtTyp = 1 then 'ของกิน' else 'ของใช้' end  FNPdtTyp
FROM 
    TWsTSal TS
INNER JOIN 
    TWsMCst C ON TS.FTSalCstCod = C.FTCstCod
INNER JOIN 
    TWsMPdt P ON TS.FTSalPdtCod = P.FTPdtCod
LEFT JOIN 
	TWsSSet S ON S.FNWstType = P.FNPdtTyp



select * from VIE_WsSal order by Quantity





http://localhost:14589/WSCRUD/GetPdt/



/// procedure
ALTER  procedure [dbo].[STP_CutOfStock](
@ptPdtCod nvarchar(10) = '',
@ptSalCod nvarchar(10) = '',
@pnSalQty int
)
as 
BEGIN TRY

declare 
@pnCheck_data int = 0
--,@ptPdtCod nvarchar(10) = 'PDT005',
--@pnSalQty int = 5,
--@ptSalCod nvarchar(10) = 'sal8'

select @pnCheck_data = count(*) from TWsMPdt where FTPdtCod = @ptPdtCod
if(@pnCheck_data > 0)
begin
update TWsMPdt set FNPdtQty = (select FNPdtQty from TWsMPdt where FTPdtCod = @ptPdtCod) - @pnSalQty where FTPdtCod = @ptPdtCod
end

select FTSalCod,FTSalPdtCod,FNSalQty,FCSalPri,FCSalAmt
      ,FTSalCstCod,FDSalDate,FDSalSMPT into #TWsTSalHis from TWsTSal where FTSalCod = @ptSalCod
 select FTPdtCod,FNPdtQty from TWsMPdt where FTPdtCod = @ptPdtCod

END TRY
BEGIN CATCH
	SELECT ERROR_MESSAGE()
END CATCH



//trigger
test ex {
CREATE TRIGGER Trigger_TWsTSal_Insert
   ON  TWsTSal
   AFTER INSERT
AS 
BEGIN
	SET NOCOUNT ON;
	select * from INSERTED

END
GO

CREATE TRIGGER Trigger_TWsTSal_Update
   ON  TWsTSal
   AFTER UPDATE
AS 
BEGIN
	SET NOCOUNT ON;
	select * from deleted

END
GO



CREATE TRIGGER Trigger_TWsTSal_Updated
   ON  TWsTSal
   AFTER UPDATE
AS 
BEGIN
	SET NOCOUNT ON;
	select * from inserted

END
GO

}


//use trigger 
CREATE TRIGGER Trigger_TWsTSal_insert
   ON TWsTSal
   AFTER INSERT
AS 
BEGIN

declare 
@pnSalQty int = 0,
@ptSalPdtCod nvarchar(10) = '',@FNResult int = 0;
	select @pnSalQty = FNSalQty, @ptSalPdtCod = FTSalPdtCod from inserted
	exec STP_CutOfStock @ptPdtCod = @ptSalPdtCod,@pnSalQty = @pnSalQty

END
GO


INSERT INTO TWsTSal (FTSalCod,FTSalPdtCod, FNSalQty, FCSalPri, FCSalAmt, FTSalCstCod, FDSalDate, FDSalSMPT) VALUES
('sal8','PDT005', 5, 200.75, 1003.75, 'CST005', '2024-05-10', '2024-05-11');
select * from TWsTSal
select * from TWsMPdt


