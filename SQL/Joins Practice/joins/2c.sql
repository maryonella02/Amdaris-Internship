Select packages.[pack_id], [First_Name], [Last_Name], packages.[speed], [monthly_payment], sectors.[sector_name]
from ((packages
inner join customers
on packages.[pack_id]=customers.[pack_id] )
inner join sectors 
on  packages.[sector_id]= sectors.[sector_id])
where sector_name= 'Business'; 