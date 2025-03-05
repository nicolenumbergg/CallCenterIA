using Blazored.LocalStorage;

namespace ClientLibrary.Helpers;

public class LocalStorageService(ILocalStorageService localStorageService)
{ 
    private const string StorageKey = "auth-token";
    public async Task<string?> GetToken() => await localStorageService.GetItemAsStringAsync(StorageKey);
    public async Task SetToken(string item) => await localStorageService.SetItemAsStringAsync(StorageKey, item);
    public async Task RemoveToken() => await localStorageService.RemoveItemAsync(StorageKey);
        
    public async Task<string?> GetItem(string key) => await localStorageService.GetItemAsStringAsync(key);
    public async Task SetItem(string key, string item) => await localStorageService.SetItemAsStringAsync(key, item);
    public async Task RemoveItem(string key) => await localStorageService.RemoveItemAsync(key);
        
    public async Task Clear() => await localStorageService.ClearAsync();
}