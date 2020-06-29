select [pack_id], [speed], [sector_id] 
from packages
where [sector_id]=(select [sector_id] from packages where [pack_id] = 10);