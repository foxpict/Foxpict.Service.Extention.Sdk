using Foxpict.Service.Infra.Model;

namespace Foxpict.Service.Extention.Sdk
{
    /// <summary>
    /// カテゴリ情報新規作成カットポイント
    /// </summary>
    public interface ICreateCategoryCutpoint : ICutpoint
    {
        /// <summary>
        /// カットポイントの呼び出し
        /// </summary>
        /// <param name="category">新規作成するカテゴリ情報</param>
         void OnCreateCategory(ICategory category);
    }
}
