namespace TeduCoreApp.Infrastructure.SharedKernel
{
    public abstract class DomainEntity<T>
    {
        public T Id { get; set; }

        public bool IsTransient()
        {
            //True: nếu mới tạo ra chưa set giá trị
            //false: đã set giá trị
            return Id.Equals(default(T));
        }
    }
}
