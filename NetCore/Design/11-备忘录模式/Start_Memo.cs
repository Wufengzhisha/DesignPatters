public class Start_Memo:IStart
{
    public void Go()
    {
        GameRole gameRole = new GameRole();
        gameRole.GetIniState();
        gameRole.StateDisplay();

        RoleStateCaretaker stateCaretaker = new RoleStateCaretaker();
        stateCaretaker.Memento = gameRole.SaveState();

        gameRole.Fight();
        gameRole.StateDisplay();

        gameRole.RecoveryState(stateCaretaker.Memento);
        gameRole.StateDisplay();
    }
}