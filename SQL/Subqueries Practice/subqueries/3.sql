select [First_Name], [Last_Name], [Join_Date] from customers
where [Join_Date] > (select [Join_Date] from customers where [Customer_Id]= 540);