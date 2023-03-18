export { faDuckDuckGo } from "./fa-duckduckgo";
export { fabill } from "./fa-bill";





Liệt kê tất cả việc vụ thể và nhóm lại (chỉ phù hợp bài tập đơn giản)


Không nhìn được thứ tự các chức năng ( thứ tự xử lý)
Biểu đồ tĩnh không giao tiếp với nhau ( thiếu sự liên quan )
 
 
Mô hình hóa tiến trình( DFD ) ( Gọi là mô hình chức năng , tập trung vào sự di chuyển của dữ liệu , muốn di chuyển phải có động cơ ( process ))

--> linh hồn phương thức hướng cấu trúc

Biểu đồ Ngữ cảnh -> kích cỡ hệ thống
Biểu đồ Mô tả luồng cho hệ thống hiện thời ( vật lý -> logic)
Biểu đồ Mô tả luồng cho hệ thống mới( logicvật lý -> vật lý)
Các mô tả chi tiết về nội dung thực hiện của mỗi tiến trình 


Mô hình logic cho biết hệ thống làm gì và là gì ( Bản chất của hệ thống )
Mô hình vật lý thể hiện cách thức hệ thống được cài đặt ( Mô hình cài đặt của hệ thống )


Mô hình logic ngắn gọn hơn , loại bỏ tư tưởng thiên lệch do ảnh hưởng bên ngoài
Giảm khả năng bỏ sót các yêu cầu nghiệp vụ
Truyền đạt tới người dùng cuối


Luồng dữ liệu : là các dữ liệu di chuyển từ vị trí này sang vị trí khác, 1 hoặc nhiều dữ liệu , sinh ra cùng thời gian , di chuyển cùng đích, hướng mũi tên 1 chiều, tên dữ liệu ghi trên luồng , tên luồng phải ghi bằng danh từ, phải đặt tên.


Kho dữ liệu

Giao tiếp với ai thì đó là tác nhân 
Mình nó thì ngữ cảnh ( mức đỉnh )



Phải luôn có đầu vào và ra 
Nếu chỉ có vào hoặc ra thì phải là tác nhân
Nếu dữ liệu di chuyển từ kho này sang kho khác -> gộp vì không có process gì
Dữ liệu không di chuyển trực tiếp từ kho dữ liệu đến tác nhân và ngược lại
Dữ liệu không thể di chuyển từ 1 tác nhân đến 1 tác nhân khác
Mũi tên dữ liệu chỉ có 1 hướng di chuyển duy nhất, không được có 2 chiều 
1 luồng dữ liệu không thể quay lại nơi nó vừa đi ra
--> cắt nhau ít nhất có thể






Quản lý doanh mục tài nguyên
