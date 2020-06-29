Select [Last_Name], [First_Name] ,[Join_Date], packages.[pack_id], packages.[speed], sectors.[sector_name]
from ((packages
inner join customers
on packages.[pack_id]=customers.[pack_id] )
inner join sectors 
on  packages.[sector_id]= sectors.[sector_id])
where sector_name= 'Private' 
 and Join_Date between '2006-01-01' and '2006-12-31'; 