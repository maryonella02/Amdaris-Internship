Select [pack_id], [speed], [monthly_payment], [sector_name]
from sectors
inner join packages
on sectors.[sector_id]= packages.[sector_id];