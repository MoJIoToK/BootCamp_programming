import cv2

img = cv2.imread('13/ExploringOpenCV/test.jpg')

#print(img)
print(img.shape)

#img = cv2.resize(img, (500, 500))
#print(img.shape)

cv2.imshow('Result', img)

cv2.waitKey(0)