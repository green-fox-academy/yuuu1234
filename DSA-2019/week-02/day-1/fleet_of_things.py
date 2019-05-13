from fleet import Fleet
from thing import Thing

getMilk=Thing("Get milk")
getMilk.complete()
removeObs=Thing("Remove the obstacles")
removeObs.complete()
standUp=Thing("Stand up")
eatLunch=Thing("Eat lunch")
fleet = Fleet()
fleet.add(getMilk)
fleet.add(removeObs)
fleet.add(standUp)
fleet.add(eatLunch)
# Create a fleet of things to have this output:
# 1. [ ] Get milk
# 2. [ ] Remove the obstacles
# 3. [x] Stand up
# 4. [x] Eat lunch

print(fleet)