Select packages.[pack_id], [First_Name], [Last_Name], packages.[speed]
from customers
inner join packages
on customers.[pack_id]= packages.[pack_id]
where packages.[pack_id]= 22 or packages.[pack_id]=27 
Order by Last_Name;