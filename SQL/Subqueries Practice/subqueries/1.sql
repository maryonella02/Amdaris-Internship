Select [First_Name], [Last_Name], [City], [State] from customers
where [State] like(select [State] from customers where [Customer_Id] = 170);