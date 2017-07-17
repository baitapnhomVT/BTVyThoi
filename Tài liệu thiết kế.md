# A CƠ SỞ LÝ THUYẾT
## I. Ngôn ngữ lập trình C#
### 1. Giới thiệu

Ngôn ngữ C# là một ngôn ngữ được dẫn xuất từ C và C++, nhưng nó được tạo từ nền tảng phát triển hơn. Microsoft bắt đầu với công việc trong C và C++ và thêm vào những đặc tính mới để làm cho ngôn ngữ này dễ sử dụng hơn. Nhiều trong số những đặc tính này khá giống với những đặc tính có trong ngôn ngữ Java. Không dừng lại ở đó, Microsoft đưa ra một số mục đích khi xây dựng ngôn ngữ này. Những mục đích này được được tóm tắt như sau:
•	C# là ngôn ngữ đơn giản
•	C# là ngôn ngữ hiện đại
•	C# là ngôn ngữ hướng đối tượng
•	C# là ngôn ngữ mạnh mẽ và mềm dẻo
•	C# là ngôn ngữ có ít từ khóa
•	C# là ngôn ngữ hướng module
•	C# sẽ trở nên phổ biến

### 2. Các kiểu dữ liệu

Tương tự như C++ hay Java, C# chia thành hai tập hợp kiểu dữ liệu chính: Kiểu xây dựng sẵn (built- in) mà ngôn ngữ cung cấp cho người lập trình và kiểu được người dùng định nghĩa (user-defined) do người lập trình tạo ra
C# phân tập hợp kiểu dữ liệu này thành hai loại: Kiểu dữ liệu giá trị (value) và kiểu dữ liệu tham chiếu (reference). Việc phân chi này do sự khác nhau khi lưu kiểu dữ liệu giá trị và kiểu dữ liệu tham chiếu trong bộ nhớ. Đối với một kiểu dữ liệu giá trị thì sẽ được lưu giữ kích thước thật trong bộ nhớ đã cấp phát là stack. Trong khi đó kiểu dữ liệu tham chiếu như các đối tượng được cấp phát trên heap. Khi một đối tượng được cấp phát trên heap thì địa chỉ của nó được trả về, và địa chỉ này được gắn đến một tham chiếu.
Bảng 1-1 Kiểu dữ liệu xây dựng sẵn
Kiểu C#	Số byte	Kiểu .NET	Mô tả
byte	1	Byte	Số nguyên dương không dấu từ 0-255
char	2	Char	Kí tự Unicode
bool	1	Boolean	Giá trị logic true/ false
sbyte	1	Sbyte	Số nguyên có dấu ( từ -128 đến 127)
short	2	Int16	Số nguyên có dấu giá trị từ -32768 đến 32767
ushort	2	Int16	Số nguyên không dấu 0 – 65.535
int	4	Int32	Số nguyên có dấu –2.147.483.647 và
2.147.483.647
uint	4	Uint32	Số nguyên không dấu 0 – 4.294.967.295
float	4	Single	Kiểu dấu chấm động, giá trị xấp xỉ từ 3,4E-
38 đến 3,4E+38, với 7 chữ số có nghĩa..
double	8	Double	Kiểu dấu chấm động có độ chính xác gấp
đôi, giá trị xấp xỉ từ 1,7E-308 đến 1,7E+308,
với 15,16 chữ số có nghĩa
decimal	8	Decimal	Có độ chính xác đến 28 con số và giá trị thập
phân, được dùng trong tính toán tài chính,
kiểu này đòi hỏi phải có hậu tố “m” hay “M”
theo sau giá trị.
long	8	Int64	Kiểu số nguyên có dấu có giá trị trong
khoảng :
-9.223.370.036.854.775.808 đến
9.223.372.036.854.775.807
ulong	8	Uint64	Số nguyên không dấu từ 0 đến
0xffffffffffffffff

Chọn một kiểu định sẵn
Tuỳ vào từng giá trị muốn lưu trữ mà ta chọn kiểu cho phù hợp. Nếu chọn kiểu quá lớn so với các giá trị cần lưu sẽ làm cho chương trình đòi hỏi nhiều bộ nhớ và chạy chậm. Trong khi nếu giá trị cần lưu lớn hơn kiểu thực lưu sẽ làm cho giá trị các biến bị sai và chương trình cho kết quả sai.
Kiểu char biểu diễn một ký tự Unicode. Ví dụ “\u0041” là ký tự “A” trên bảng Unicode. Một số ký tự đặc biệt được biểu diễn bằng dấu “\” trước một ký tự khác
Kiểu dữ liệu do người dùng định nghĩa
- Tất cả kiểu dữ liệu do người dùng định nghĩa ngoài trừ kiểu cấu trúc điều là kiểu dữ liệu tham chiếu
Một sô kiểu dữ liệu do người dùng định nghĩa gồm
•	object: đây là kiểu dữ liệu cơ sở chứa tất cả các kiểu dữ liệu khác trong C#.
•	string: kiểu dữ liệu chuỗi ký tự.
•	class: kiểu dữ liệu class.
•	delegate: kiểu dữ liệu chuyển giao.
•	interface: kiểu dữ liệu giáo tiếp.
•	array: kiểu dữ liệu mảng.
### 3. Các toán tử
Toán tử được kí hiệu bằng một biểu tượng dùng để thực hiện một hành động. Các kiểu dữ liệu cơ bản của C# như kiểu nguyên hỗ trợ rất nhiều các toán tử như toán tử gán, toán tử toán học, logic....
Các phép toán +, -, *, / là một ví dụ về toán tử. Áp dụng các toán tử này lên các biến kiểu số ta có kết quả như việc thực hiện các phép toán thông thường.
int a = 10;
int b = 20;
int c = a + b; // c = 10 + 20 = 30
C# cung cấp cấp nhiều loại toán tử khác nhau để thao tác trên các kiểu biến dữ liệu, được liệt kê trong bảng sau theo từng nhóm ngữ nghĩa. 
Bảng 1.2 Các nhóm toán tử trong C#
Nhóm toán tử	Toán tử	Ý nghĩa
Toán học	+ - * / %	Cộng, trừ, nhân, chia, chia lấy phần dư
Logic	& | ^ ! ~ && true false	Phép toàn logic và thao tác trên bit
Ghép chuỗi	+	Ghép nối hai chuỗi
Tăng, giảm	++, --	Tăng/giảm toán hạng lên/xuống 1. Đứng trước hoặc sau toán hạng
Dịch bit	<< >>	Dịch trái, dịch phải
Quan hệ	== != < > <= >=	Bằng, khác, nhỏ hơn, lớn hơn, nhỏ hơn hoặc bằng, lớn hơn hoạc bằng
Gắn	= += -= *= /= %= &= != ^ = <<= >>=	Phép gắn
Chỉ số	[]	Cách truy xuất phần tử của mảng
Ép kiểu	()	
Indirecti0on và Address	* ->  [] &	Dùng cho con trỏ

3.1 Toán tử gán (=)
Toán tử gán (=) Toán tử này cho phép thay đổi các giá trị của biến bên phải toán tử bằng giá trị bên trái toán tử.
3.2 Nhóm toán tử toán học
C# dùng các toàn tử số học với ý nghĩa theo đúng tên của chúng như: + (cộng), – (trừ)  * (nhân) và / (chia). Tùy theo kiểu của hai toán hạng mà toán tử trả về kiểu tương ứng. Ngoài ra, còn có toán tử % (lấy phần dư) được sử dụng trong các kiểu số nguyên.
3.3 Các toán tử tăng và giảm
C# cũng kế thừa từ C++ và Java các toán tử: +=,-=, *=, /= , %= nhằm làm đơn giản hoá. Nó còn kế thừa các toán tử tiền tố và hậu tố (như biến++, hay ++biến) để giảm bớt sự cồng kềnh trong các toán tử cổ điển.
3.4 Các toán tử quan hệ
Các toán tử quan hệ được dùng để so sánh hai giá trị với nhau và kết quả trả về có kiểu Boolean. Toán tử quan hệ gồm có: == (so sánh bằng), != (so sánh khác), > (so sánh lớn hơn), >= (lớn hơn hay bằng), < (so sánh nhỏ hơn), <= (nhỏ hơn hay bằng).
3.5 Các toán tử logic
Các toán tử logic gồm có: && (và), || (hoặc), ! (phủ định). Các toán tử này được dùng trong các biểu thức điều kiện để kết hợp các toán tử quan hệ theo một ý nghĩa nhất định.
3.6 Thứ tự các toán tử
Đối với các biểu thức toán, thứ tự ưu tiên là thứ tự được qui định trong toán học. Còn thứ tự ưu tiên thực hiện của các nhóm toán tử được liệt kê theo bảng dưới đây
Bảng 1-3 Thứ tự ưu tiên của các nhóm toán tử (chiều ưu tiên từ trên xuống)
Nhóm toán tử	Toán tử	Ý nghĩa
Primary(chính)	{x} x.y f(x) a[x] x++ x--	
Unary	+ - ! ~ ++x –x (T)x	
Nhân	*  / %	Nhân, chia, chia lấy phần dư
Cộng	+ - 	công, trừ
Dịch bit	<< >>	Dịch trái dịch phải
Bằng	== !=	Bằng, khác
Logic trên bit AND	&	Và trên bit
XOR	^	Xor trên bit
OR	|	Hoặc trên bit
Điều kiện AND	&&	Và trên biểu thức điều kiện
Điều kiện OR	||	Hoặc trên biểu thức điều kiện
Điều kiện	?:	Điều kiện tượng tự if
Asignment	= *= /= %= += -= <<= =>> &= ^= |=	

3.7 Toán tử tam phân
Cú pháp:
<biểu thức điều kiện>? <biểu thức 1>: <biểu thức 2>;
Ý nghĩa:
•	Nếu biểu thức điều kiện đúng thì thực hiện biểu thức 1.
•	Nếu sai thì thực hiện biểu thức 2.
### 4. Cấu trúc rẽ nhánh
a. Câu lệnh if… else …
Cú pháp:
if ( biểu thức logic )
khối lệnh;
hoặc
if ( biểu thức logic )
 		khối lệnh 1;
else
 		khối lệnh 2;
Ghi chú: Khối lệnh là một tập các câu lện trong cặp dấu “{…}”. Bất kỳ nơi đâu có câu lệnh thì ở đó có thể viết bằng một khối lệnh.
Biểu thức logic là biểu thức cho giá trị dúng hoặc sai (true hoặc false). Nếu “biểu thức logic” cho giá trị đúng thì “khối lệnh” hay “khối lệnh 1” sẽ được thực thi, ngược lại “khối lệnh 2” sẽ thực thi. Một điểm khác biệt với C++ là biểu thức trong câu lệnh if phải là biểu thức logic, không thể là biểu thức số. 
b. Câu lệnh switch case
Cú pháp:
switch ( biểu_thức_lựa_chọn )
{
case biểu_thức_hằng :
 		khối lệnh;
 		lệnh nhảy;
 	[ default :
 		khối lệnh;
 	lệnh nhảy; ]
}
Biểu thức lựa chọn là biểu thức sinh ra trị nguyên hay chuỗi. Switch sẽ so sánh biểu_thức_lựa_chọn với các biểu_thức_hằng để biết phải thực hiện với khối lệnh nào. Lệnh nhảy như break, goto…để thoát khỏi câu switch và bắt buộc phải có.
	int nQuyen = 0;
switch ( sQuyenTruyCap )
{
case “Administrator”:
 nQuyen = 1;
 break;
case “Admin”:
 goto case “Administrator”;
default:
 nQuyen = 2;
break;
}
c. Câu lệnh for
Cú pháp:
for ( [khởi_tạo_biến_đếm]; [biểu_thức]; [gia_tăng_biến_đếm] )
 khối lệnh;
Ví dụ 3-4 Tính tổng các số nguyên từ a đến b
int a = 10; int b = 100; int nTong = 0;
d. Câu lệnh while
Cú pháp:
while ( biểu_thức_logic )
 khối_lệnh;
Khối_lệnh sẽ được thực hiện cho đến khi nào biểu thức còn đúng. Nếu ngay từ đầu biểu thức sai, khối lệnh sẽ không được thực thi.
e. Câu lệnh do …while
Cú pháp:
do
 khối_lệnh
while ( biếu_thức_logic )
Khác với while khối lệnh sẽ được thực hiện trước, sau đó biệu thức được kiểm tra. Nếu biểu thức đúng khối lệnh lại được thực hiện. 

# B. PHÂN TÍCH THIẾT KẾ

## I. Phân tích chức năng
Ứng dụng quản lí sinh viên có thể giúp công việc quản lí sinh viên trở lên dễ dàng, nhanh chóng, độ chính xác cao.
Chức năng ứng dụng:
-	Quản lí sinh viên: thêm mới, sửa, xóa, tìm kiếm sinh viên
-	Quản lí điểm thi: nhập điểm, sửa điểm, xóa điểm thi của sinh viên
-	Quản lí lớp: thêm mới, sửa xóa.
-	Quản lí môn học: thêm ,sửa xóa, tìm kiếm môn học
-	Quản lí khoa: thêm, sửa xóa khoa
## II. Cơ sở dữ liệu
### 1.Quan hệ dữ liệu
<p align="center">
  <img width="650" height="400" src="https://github.com/baitapnhomVT/BTVyThoi/blob/master/CSDL.png">
</p>                

### 2. Các bảng
2.1. Bảng Khoa	
KHOA
Tên trường	Kiểu dữ liệu	Ghi chú
MaKhoa	Short Text (10)	Khóa chính
Bắt buộc nhập
TenKhoa	Short Text (50)	
	
2.2 Bảng sinh viên	
SINHVIEN
Tên trường	Kiểu dữ liệu	Ghi chú
MaSV	Short Text (10)	Khóa chính
Bắt buộc nhập
Ho	Short Text (50)	
Ten	Short Text (10)	
GioiTinh	Yes/No	
NoiSinh	Short Text (50)	
HoKhau	Short Text (50)	
DanToc	Short Text (10)	
SoDienThoai	Number (Long Integer)	
MaLop	Short Text (10)	

2.3 Bảng Kết quả

DIEMTHI
Tên trường	Kiểu dữ liệu	Ghi chú
MaMonHoc	Short Text (10)	Khóa chính
Bắt buộc nhập
MaSV	Short Text (10)	Khóa chính
Bắt buộc nhập
DiemThiLan1	Double	
DiemThiLan2	Double	


2.4 Bảng Môn học
MONHOC
Tên trường	Kiểu dữ liệu	Ghi chú
MaMonHoc	Short Text (10)	Khóa chính
Bắt buộc nhập
TenMonHoc	Short Text (50)	
SoDV	Number(Long Integer)	Số đơn vị học phần

## III. Các lớp
## 1. Lớp Khoa
KHOA
Tên thuộc tính	Kiểu dữ liệu	Ghi chú
MaKhoa	string	
TenKhoa	string	
Tên phương thức	Kiểu dữ liệu trả về	Chức năng
Them()	void	Nhập một khoa vào DataBase
Sua()	void	Sửa một khoa trong DataBase
Xoa()	void	Xóa một khoa một DataBase

## 2. Lớp Sinh viên
SINHVIEN
Tên thuộc tính	Kiểu dữ liệu	Ghi chú
MaSV	string	
Ho	string	
Ten	string	
GioiTinh	bool	
NgaySinh	string	
NoiSinh	string	
HoKhau	string	
DanToc	string	
SoDienThoai	int	
MaLop	string	
Tên phương thức	Kiểu dữ liệu trả về	Chức năng
Them()	void	Nhập một sinh viên vào DataBase
Sua()	void	Sửa một sinh viên trong DataBase
Xoa()	void	Xóa một sinh viên một DataBase

### 3.Lớp Kết quả

KETQUA
Tên thuộc tính	Kiểu dữ liệu	Ghi chú
MaMonHoc	string	
MaSV	string	
DiemThiLan1	int	
DiemThiLan1	int	
Tên phương thức	Kiểu dữ liệu trả về	Chức năng
Them()	void	Nhập một điểm thi vào DataBase
Sua()	void	Sửa một điểm thi trong DataBase
Xoa()	void	Xóa một điểm thi một DataBase

### 4. Lớp Môn học
MONHOC
Tên thuộc tính	Kiểu dữ liệu	Ghi chú
MaMonHoc	string	
TenMonHoc	string	
SoDonViHocPhan	int	
Tên phương thức	Kiểu dữ liệu trả về	Chức năng
Them()	void	Nhập một môn học vào DataBase
Sua()	void	Sửa một môn học trong DataBase
Xoa()	void	Xóa một môn học một DataBase

### 5. Lớp clsDuLieu
clsDuLieu
Tên phương thức	Kiểu dữ liệu trả về	Chức năng
KetNoi()	void	Tạo kết nối đến DataBase
GetDataSet(String TenBang)	DataSet	Lấy dữ liệu từ 1 bảng đưa vào DataSet
GetDataSet(String TenBang,string TenCacTruong)	DataSet	Lấy dữ liệu từ 1 bảng đưa gồm nhiều trường được chỉ định và đưa vào DataSet
GetDataSetSQLCommand(string strSQL)	DataSet	Lấy dữ liệu theo lệnh SQL và đưa vào DataSet
GetDataSetDieuKien(string TenBang,string DieuKien)	DataSet	Lấy dữ liệu theo điều kiện và đưa vào DataSet
KiemTraMa(string DieuKien)	bool	Kiểm tra mã đã có trong bảng hay chưa
KiemTraMa(string TenBang,string DieuKien)	bool	Kiểm tra mã đã có trong bảng hay chưa
RunSQL(string strSQL)	bool	Chạy một câu lệnh SQL


