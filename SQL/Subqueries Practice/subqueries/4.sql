

select [First_Name], [Last_Name], [City], [State], [pack_id]
from customers
where pack_id in 
(select pack_id from packages where speed='5Mbps')