import numpy as np
import matplotlib.pyplot as plt

# 生成隨機彩色圖案的 AI 繪圖程式
def generate_random_art(width, height):
    # 創建一個空白的三通道圖像（RGB）
    image = np.zeros((height, width, 3), dtype=np.uint8)

    # 生成隨機顏色
    red = np.random.randint(0, 256)
    green = np.random.randint(0, 256)
    blue = np.random.randint(0, 256)
    color = (red, green, blue)

    # 在圖像上繪製隨機圖案
    for _ in range(np.random.randint(5, 20)):
        x1, y1 = np.random.randint(0, width), np.random.randint(0, height)
        x2, y2 = np.random.randint(0, width), np.random.randint(0, height)
        thickness = np.random.randint(1, 10)
        cv2.line(image, (x1, y1), (x2, y2), color, thickness)

    return image

if __name__ == "__main__":
    width, height = 800, 600
    art_image = generate_random_art(width, height)

    # 顯示生成的圖像
    plt.imshow(art_image)
    plt.axis('off')
    plt.show()