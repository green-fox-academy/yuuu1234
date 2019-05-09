import re
print(re.match('[Aa]dmin', "Admin"))
print(re.match('\d{1}|[1-9]\d| 100','09'))#need more consideration
print(re.match(r'(00\s)?((\+?[\d]{2})\s)(\+?[\d]{2}\s)(([\d]{3})|([\d]{2}))(\s[\d]{4})',"00 +36 70 381 1288"))
print(re.match(r'([\w]+\.?([\w]+)?)(@greenfox)(\.)?(academy)(\.com)?',"jane@greenfox.academy"))
print(re.search(r'(src=").*(\.png)"','<img alt="Cat picture" src="./images/cat-01.png">',re.IGNORECASE))