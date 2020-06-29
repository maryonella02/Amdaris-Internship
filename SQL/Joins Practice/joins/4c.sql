Select [First_Name], [Last_Name], [speed], [monthly_payment] 
from customers
right outer join packages
on customers.[pack_id]= packages.[pack_id];