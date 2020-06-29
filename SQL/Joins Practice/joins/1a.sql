Select packages.[pack_id], [First_Name], [Last_Name], packages.[speed]
from customers
inner join packages
on customers.[pack_id]= packages.[pack_id];