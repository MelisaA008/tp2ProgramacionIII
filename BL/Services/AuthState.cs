namespace tp2ProgramacionIII.BL.Services
{
    public class AuthState
    {
        public bool IsAuthenticated { get; private set; } = false;

        // Evento que notifica cambios
        public event Action? OnChange;

        public void SetAuth(bool value)
        {
            IsAuthenticated = value;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}

