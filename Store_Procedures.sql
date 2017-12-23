create procedure ShowDetailReceipt @id int
as begin
	select a.CustID,a.CustName,b.AccAmt,b.DAcc,b.CAcc,b.VoucherDescr,b.AttachDescr,a.Address from Customer a,RVoucherDet b
	where a.CustID = b.CustID and b.VMainID = @id
end

exec ShowDetailReceipt 
---
use TMS
go


create procedure ShowAccountTrans @id int
as SELECT [TranID]
      ,[TranDate]
      ,[dbo].[AccountTrans].[TranType]
	  ,[dbo].[TranTypes].[TranTypeName]
      ,[DocDate]
      ,[RefNo]
      ,[RefDate]
      ,[Des_StationID]
      ,[Dep_StationID]
      ,[Descr]
      ,[CostVol]
      ,[ActVol]
      ,[UnitPrice]
      ,[DAcc]
      ,[CAcc]
      ,[OrigAmt]
      ,[SlsPerID]
      ,[D_CustID]
	  ,[dbo].[Customer].[CustName]
      ,[C_CustID]
      ,[Released]
      ,[Completed]
  FROM [dbo].[AccountTrans],[dbo].[TranTypes],[dbo].[Customer] 
  WHERE [dbo].[AccountTrans].D_CustID=[dbo].[Customer].CustID and [dbo].[AccountTrans].TranType=[dbo].[TranTypes].TranType and
  D_CustID in (select RVoucherDet.CustID from RVoucherDet,ReceiptVoucher,Customer where RVoucherDet.VMainID=ReceiptVoucher.VoucherID and RVoucherDet.CustID=Customer.CustID and VMainID=@id and (RVoucherDet.CustID<>'HN' and Customer.Status>0))
  order by D_CustID

 exec ShowAccountTrans 297

---
CREATE VIEW [dbo].[ShowReceipt]
AS
SELECT        dbo.ReceiptVoucher.VoucherID, dbo.ReceiptVoucher.VoucherDate, dbo.SalesPerson.SlsPerName, dbo.ReceiptVoucher.Payer, dbo.ReceiptVoucher.PAddress, dbo.ReceiptVoucher.TotalAmt, 
                         dbo.ReceiptVoucher.MVoucherDescr
FROM            dbo.ReceiptVoucher INNER JOIN
                         dbo.SalesPerson ON dbo.ReceiptVoucher.SlsPerID = dbo.SalesPerson.SlsPerID


--
create procedure [dbo].[ShowReceipt_SlsPer] @id nvarchar(20)
as begin
	SELECT dbo.ReceiptVoucher.VoucherID, dbo.ReceiptVoucher.VoucherDate, dbo.SalesPerson.SlsPerName, dbo.ReceiptVoucher.Payer, dbo.ReceiptVoucher.PAddress, dbo.ReceiptVoucher.TotalAmt, 
                         dbo.ReceiptVoucher.MVoucherDescr
	FROM dbo.ReceiptVoucher INNER JOIN dbo.SalesPerson ON dbo.ReceiptVoucher.SlsPerID = dbo.SalesPerson.SlsPerID 
	where dbo.SalesPerson.SlsPerID = @id
end

--
create procedure [dbo].[ShowReceipt_Time] @month int,@year int
as begin
	SELECT dbo.ReceiptVoucher.VoucherID, dbo.ReceiptVoucher.VoucherDate, dbo.SalesPerson.SlsPerName, dbo.ReceiptVoucher.Payer, dbo.ReceiptVoucher.PAddress, dbo.ReceiptVoucher.TotalAmt, 
                         dbo.ReceiptVoucher.MVoucherDescr
	FROM dbo.ReceiptVoucher INNER JOIN dbo.SalesPerson ON dbo.ReceiptVoucher.SlsPerID = dbo.SalesPerson.SlsPerID 
	where MONTH(dbo.ReceiptVoucher.VoucherDate)=@month and YEAR(dbo.ReceiptVoucher.VoucherDate)=@year
end
GO


create procedure FindCustByID @id nvarchar(20)
as begin
	SELECT * FROM Customer WHERE CustID LIKE '%'+@id+'%'
end