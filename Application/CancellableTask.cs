using Domain.Enums;

namespace Application
{
    public class CancellableTask
    {
        #region Variables
        public CancellationReason Reason { get; set; }
        public CancellationTokenSource TokenSource { get; }
        #endregion

        #region Constructors

        public CancellableTask()
        {
            TokenSource = new CancellationTokenSource();
            Reason = CancellationReason.Undefined;
        }
        #endregion
        #region Methods 
        public void Cancel(CancellationReason reason = CancellationReason.UserCancelled)
        {
            Reason = reason;
            TokenSource.Cancel();
        }

        public CancellationToken Token => TokenSource.Token;

        #endregion
    }
}
