n = int(input("Sayı giriniz: "))
m = int(input("Sayı giriniz: "))
toplam = 0
yediye_tam_bolunenler =[]
if m>=n:
    for i in range(n,m+1):
        if i%7 ==0:
            yediye_tam_bolunenler.append(i)
else:
    for i in range(m,n+1):
        if i%7 ==0:
            yediye_tam_bolunenler.append(i)
print("Girdiğiniz değerler arasında 7'de tam bolunenler: {} ".format(yediye_tam_bolunenler))